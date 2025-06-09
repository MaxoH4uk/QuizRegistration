using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuizRegistration.Models;
using QuizRegistration.Services;

namespace QuizRegistration;

public partial class Form1 : Form
{
    private readonly IConfiguration _config;
    private readonly TokenService _tokenService;

    private Image _closeEyeImg;

    private bool _isPasswordHidden = true;
    private Image _openEyeImg;

    public Form1(TokenService tokenService, IConfiguration config)
    {
        _tokenService = tokenService ?? throw new ArgumentNullException(nameof(tokenService));
        _config = config ?? throw new ArgumentNullException(nameof(config));

        InitializeComponent();
        InitializeControls();
        ReadUserCretentialsFromFile();
    }

    private void InitializeControls()
    {
        _openEyeImg = LoadImageFromResources("QuizRegistration.Resources.openEye.png");
        _closeEyeImg = LoadImageFromResources("QuizRegistration.Resources.closeEye.png");

        passwordField.IconRight = _closeEyeImg;
    }

    private async void LoginButton_Click(object sender, EventArgs e)
    {
        wrongPasswordLabel.Text = string.Empty;

        try
        {
            var credentials = new UserCredentials(emailField.Text, passwordField.Text);

            if (savePasswordCheckbox.Checked) WriteUserCretentialsToFile(credentials);

            await _tokenService.GetTokenAsync(credentials);

            Hide();

            using (var form2 = Program.ServiceProvider.GetRequiredService<Form2>())
            {
                form2.ShowDialog();
            }

            Close();
        }
        catch (Exception ex)
        {
            wrongPasswordLabel.Text = ex.Message;
        }
    }

    private void EmailField_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;

        passwordField.Focus();
        e.Handled = true;
    }

    private void PasswordField_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;

        loginBtn.PerformClick();
        e.Handled = true;
    }

    private Image LoadImageFromResources(string resourceName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var stream = assembly.GetManifestResourceStream(resourceName);

        if (stream == null)
            throw new ArgumentException(
                string.Format(
                    Program.GetResourceString("ResourseNotFoundError"),
                    resourceName
                    )
                );

        return Image.FromStream(stream);
    }

    private void passwordField_IconRightClick(object sender, EventArgs e)
    {
        _isPasswordHidden = !_isPasswordHidden;
        passwordField.UseSystemPasswordChar = _isPasswordHidden;
        passwordField.PasswordChar = _isPasswordHidden ? '●' : '\0';
        passwordField.IconRight = _isPasswordHidden ? _closeEyeImg : _openEyeImg;
    }

    private void ReadUserCretentialsFromFile()
    {
        const string userDataFilePath = @"UserData.txt";

        var userDataFile = new FileInfo(userDataFilePath);

        if (!userDataFile.Exists) return;

        var fileText = File.ReadAllText(userDataFilePath);
        var userData = fileText.Split(';');

        var decriptedUserEmail = DecryptString(userData[0]);
        var decriptedUserPassword = DecryptString(userData[1]);

        emailField.Text = decriptedUserEmail;
        passwordField.Text = decriptedUserPassword;
    }

    private void WriteUserCretentialsToFile(UserCredentials credentials)
    {
        const string userDataFilePath = @"UserData.txt";
        var encriptedUserEmail = EncryptString(credentials.Email);
        var encriptedUserPassword = EncryptString(credentials.Password);

        using var fs = File.Create(userDataFilePath);
        var info = new UTF8Encoding(true).GetBytes($"{encriptedUserEmail};{encriptedUserPassword}");
        fs.Write(info, 0, info.Length);
    }

    private string EncryptString(string data)
    {
        var toEncryptedArray = Encoding.UTF8.GetBytes(data);

        var objMd5CryptoService = new MD5CryptoServiceProvider();

        var securityKeyArray = objMd5CryptoService.ComputeHash(
            Encoding.UTF8.GetBytes(
                _config["Encryption:Key"] ?? string.Empty
            )
        );
        objMd5CryptoService.Clear();

        var objTripleDesCryptoService = new TripleDESCryptoServiceProvider();
        objTripleDesCryptoService.Key = securityKeyArray;
        objTripleDesCryptoService.Mode = CipherMode.ECB;
        objTripleDesCryptoService.Padding = PaddingMode.PKCS7;


        var objCrytpoTransform = objTripleDesCryptoService.CreateEncryptor();
        var resultArray = objCrytpoTransform.TransformFinalBlock(
            toEncryptedArray, 0, toEncryptedArray.Length
        );
        objTripleDesCryptoService.Clear();

        return Convert.ToBase64String(resultArray, 0, resultArray.Length);
    }

    private string DecryptString(string data)
    {
        var toEncryptArray = Convert.FromBase64String(data);
        var objMd5CryptoService = new MD5CryptoServiceProvider();

        var securityKeyArray = objMd5CryptoService.ComputeHash(
            Encoding.UTF8.GetBytes(
                _config["Encryption:Key"] ?? string.Empty
            )
        );
        objMd5CryptoService.Clear();

        var objTripleDesCryptoService = new TripleDESCryptoServiceProvider();
        objTripleDesCryptoService.Key = securityKeyArray;
        objTripleDesCryptoService.Mode = CipherMode.ECB;
        objTripleDesCryptoService.Padding = PaddingMode.PKCS7;

        var objCrytpoTransform = objTripleDesCryptoService.CreateDecryptor();
        var resultArray = objCrytpoTransform.TransformFinalBlock(
            toEncryptArray, 0, toEncryptArray.Length
        );
        objTripleDesCryptoService.Clear();

        return Encoding.UTF8.GetString(resultArray);
    }

    private void savePasswordCheckbox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;

        savePasswordCheckbox.Checked = !savePasswordCheckbox.Checked;
        e.Handled = true;
    }
}
