using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QuizRegistration.Models;
using QuizRegistration.Services;
using Newtonsoft.Json;

namespace QuizRegistration;

public partial class Form2 : Form
{
    private readonly GameService _gameService;

    public Form2(GameService gameService)
    {
        _gameService = gameService;

        InitializeComponent();

        SetQuizesData();
        SetTeamsData();
    }

    private async void SetQuizesData()
    {
        chooseGameDropdown.DataSource = (
            await _gameService.GetQuizesData()).OrderBy(g => g.PlayedAt
        ).ToList();
        chooseGameDropdown.DisplayMember = "GameName";
    }

    private async void SetTeamsData()
    {
        var userData = await _gameService.GetUserData();

        chooseTeamDropdown.DataSource = userData.OrderBy(g => g.Name).ToList();
        chooseTeamDropdown.DisplayMember = "Name";

        captainNameInput.Text = userData[0].Captain.Name;
        captainPhoneInput.Text = userData[0].Captain.Phone;
    }

    private async void chooseGameDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (chooseGameDropdown.SelectedItem is not Game selectedGame) return;

        var gameDate = DateTime.ParseExact(
            selectedGame.PlayedAt,
            "yyyy-MM-ddTHH:mm:ss",
            CultureInfo.InvariantCulture
        );
        var gameDateStr = gameDate.ToString("dd MMMM yyyy в HH:mm", new CultureInfo("ru-RU"));
        gameDateLabel.Text = string.Format(Program.GetResourceString("GameDateMsg"), gameDateStr);

        var regDate = DateTime.ParseExact(
            selectedGame.RegistrationAt,
            "yyyy-MM-ddTHH:mm:ss",
            CultureInfo.InvariantCulture
        );
        var regDateStr = regDate.ToString("dd MMMM yyyy в HH:mm", new CultureInfo("ru-RU"));
        registrationDateLabel.Text = string.Format(Program.GetResourceString("RegDateMsg"), regDateStr);

        gamePlaceLabel.Text = string.Format(
            Program.GetResourceString("GamePlaceMsg"),
            selectedGame.Place,
            selectedGame.Address
        );

        gameBanner.Image = await _gameService.LoadImageFromUrlAsync(selectedGame.MediaBanner.Head);
        gameBanner.SizeMode = PictureBoxSizeMode.Zoom;
    }

    private async void registrationBtn_Click(object sender, EventArgs e)
    {
        if (chooseGameDropdown.SelectedItem is not Game selectedGame)
        {
            MessageBox.Show(
                Program.GetResourceString("SelectGameMsg"),
                Program.GetResourceString("SelectGameMsg"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            return;
        }

        if (chooseTeamDropdown.SelectedItem is not Team selectedTeam)
        {
            MessageBox.Show(
                Program.GetResourceString("SelectTeamMsg"),
                Program.GetResourceString("SelectTeamMsg"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            return;
        }

        if (string.IsNullOrEmpty(captainNameInput.Text))
        {
            MessageBox.Show(
                Program.GetResourceString("SelectCaptainNameMsg"),
                Program.GetResourceString("SelectCaptainNameMsg"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            return;
        }

        if (string.IsNullOrEmpty(captainPhoneInput.Text))
        {
            MessageBox.Show(
                Program.GetResourceString("SelectCaptainPhoneMsg"),
                Program.GetResourceString("SelectCaptainPhoneMsg"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            return;
        }

        selectedTeam.Captain.Name = captainNameInput.Text;
        selectedTeam.Captain.Phone = captainPhoneInput.Text;

        var eventRegistration = new EventRegistration(
            selectedGame,
            selectedTeam,
            Convert.ToByte(choosePlayersCountField.Text)
        );
        var eventRegistrationJson = JsonConvert.SerializeObject(eventRegistration, Formatting.Indented);

        var openRegDate = DateTime.ParseExact(
            selectedGame.RegistrationAt,
            "yyyy-MM-ddTHH:mm:ss",
            CultureInfo.InvariantCulture
        );

        var openRegDateStr = openRegDate.ToString("dd MMMM yyyy в HH:mm", new CultureInfo("ru-RU"));
        registrationLogInput.SelectionColor = Color.CornflowerBlue;
        registrationLogInput.AppendText(
            string.Format(
                Program.GetResourceString("SendRegistrationMsg"),
                selectedGame.GameName,
                openRegDateStr
            )
        );

        while (true)
        {
            var registrationResponse = await _gameService.RegisterToQuiz(
                new StringContent(
                    eventRegistrationJson,
                    Encoding.UTF8,
                    "application/json")
            );

            if (registrationResponse.StatusCode != HttpStatusCode.Created) continue;

            var regDate = DateTime.Now.ToString(
                "dd MMMM yyyy в HH:mm:ss:fff",
                new CultureInfo("ru-RU")
            );
            registrationLogInput.SelectionColor = Color.Green;
            registrationLogInput.AppendText(
                string.Format(
                    Program.GetResourceString("SuccessRegistrationMsg"),
                    selectedGame.GameName,
                    regDate
                )
            );
            break;
        }
    }

    private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (formTabs.SelectedTab != gamesTab) return;

        ShowActualGames();
    }

    private async void ShowActualGames()
    {
        gamesTab.Controls.Clear();

        var gamesRegistrations = await _gameService.GetActualGamesRegistrations();

        var pageTitleLabel = new Label
        {
            Font = new Font("Century Gothic", 14F, FontStyle.Bold),
            Dock = DockStyle.Top,
            TextAlign = ContentAlignment.MiddleCenter,
            Height = 50,
            Text = Program.GetResourceString("GamesTabTitle")
        };

        if (gamesRegistrations.Count == 0)
        {
            gamesTab.Controls.Add(pageTitleLabel);

            var infoLabel = new Label
            {
                Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = Program.GetResourceString("NoRegistrationsMsg")
            };
            gamesTab.Controls.Add(infoLabel);
        }
        else
        {
            foreach (var game in gamesRegistrations)
            {
                var tableLayout = new TableLayoutPanel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    ColumnCount = 2,
                    RowCount = 5,
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 0, 0, 0),
                    Height = 200
                };

                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
                tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));

                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));

                var titleLabel = new Label
                {
                    Text = game.GameName,
                    Font = new Font("Century Gothic", 12F, FontStyle.Bold),
                    Margin = new Padding(10, 0, 0, 0),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                tableLayout.Controls.Add(titleLabel, 0, 0);

                var gameDate = DateTime.ParseExact(
                    game.PlayedAt, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture
                );
                var dateLabel = new Label
                {
                    Text = string.Format(
                        Program.GetResourceString("GameDateMsg"),
                        gameDate.ToString("dd MMMM yyyy в HH:mm",
                            new CultureInfo("ru-RU")
                        )
                    ),
                    Font = new Font("Century Gothic", 10F, FontStyle.Regular),
                    Margin = new Padding(10, 0, 0, 0),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                tableLayout.Controls.Add(dateLabel, 0, 1);

                var placeLabel = new Label
                {
                    Text = string.Format(
                        Program.GetResourceString("GamePlaceMsg"),
                        game.Place,
                        game.Address
                    ),
                    Font = new Font("Century Gothic", 10F, FontStyle.Regular),
                    Margin = new Padding(10, 0, 0, 0),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                tableLayout.Controls.Add(placeLabel, 0, 2);

                var playersCountLabel = new Label
                {
                    Text = string.Format(
                        Program.GetResourceString("PlayersCountMsg"),
                        game.PlayerCount
                    ),
                    Font = new Font("Century Gothic", 10F, FontStyle.Regular),
                    Margin = new Padding(10, 0, 0, 0),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                tableLayout.Controls.Add(playersCountLabel, 0, 3);

                var registrationDate = DateTime.ParseExact(
                    game.RegistrationAt, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture
                );
                var registrationTimeLabel = new Label
                {
                    Text = string.Format(
                        Program.GetResourceString("RegistrationDateMsg"),
                        registrationDate.ToString("dd MMMM yyyy в HH:mm",
                            new CultureInfo("ru-RU")
                        )
                    ),
                    Font = new Font("Century Gothic", 10F, FontStyle.Regular),
                    Margin = new Padding(10, 0, 0, 0),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                tableLayout.Controls.Add(registrationTimeLabel, 0, 4);

                var cancelButton = new Button
                {
                    Text = Program.GetResourceString("CancelRegistrationMsg"),
                    Font = new Font("Century Gothic", 10F, FontStyle.Regular),
                    Margin = new Padding(0, 0, 20, 0),
                    Dock = DockStyle.Fill,
                    UseVisualStyleBackColor = true,
                    Tag = game.Id
                };
                cancelButton.Click += cancelButton_Click;
                tableLayout.Controls.Add(cancelButton, 1, 1);
                tableLayout.SetRowSpan(cancelButton, 3);

                var separator = new Guna2Separator
                {
                    Dock = DockStyle.Top,
                    Height = 20
                };

                gamesTab.Controls.Add(separator);
                gamesTab.Controls.Add(tableLayout);
            }

            gamesTab.Controls.Add(pageTitleLabel);
        }
    }

    private async void cancelButton_Click(object sender, EventArgs e)
    {
        if (sender is not Button { Tag: uint id }) return;

        var deletionResponse = await _gameService.CancelRegistration(id);

        if (deletionResponse.StatusCode == HttpStatusCode.OK)
        {
            MessageBox.Show(Program.GetResourceString("SuccessfulGameCancellation"));
            ShowActualGames();
        }
        else
        {
            MessageBox.Show(Program.GetResourceString("ErrorGameCancellation"));
        }
    }

    private void captainPhoneInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) &&
            !char.IsDigit(e.KeyChar) &&
            e.KeyChar != ' ' &&
            e.KeyChar != '+' &&
            e.KeyChar != '(' &&
            e.KeyChar != ')' &&
            e.KeyChar != '-')
            e.Handled = true;
    }
}
