using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArenaModdingTool.ModdingFiles;
using ArenaModdingTool.Forms;

namespace ArenaModdingTool.Controls
{
    public partial class ucCultureDetails : UserControl
    {
        private ModdingProject project;
        private MBBannerlordCulture culture;
        private int index;
        private AddEditState addEditState;

		public event Action<MBBannerlordCulture, AddEditState, int> SaveCultureInfoFinished;

		public ucCultureDetails(ModdingProject project, MBBannerlordCulture culture, int index, AddEditState addEditState)
        {
            InitializeComponent();
            initializeTooltip();

            this.project = project;
            this.index = index;
            this.addEditState = addEditState;

			switch(addEditState)
			{
				case AddEditState.Add:
					this.culture = new MBBannerlordCulture();
					break;
				case AddEditState.Edit:
					this.culture = culture;
					loadCultureDetails();
					break;
			}
        }

		private void initializeTooltip()
		{
            foreach (TabPage tabPage in tabCtrlCultureDetails.TabPages)
            {
                foreach (Control control in tabPage.Controls[0].Controls)
                {
                    if (control is TextBox || control is CheckBox)
                    {
                        string fieldName = Helper.RenameSnakeCase(control.Name.Substring(2));
                        toolTip.SetToolTip(control, Helper.LOC("str_tooltip_message_culture_details_" + fieldName));
                    }
                }
            }
		}

		private void loadCultureDetails()
        {
            loadDataFromCulture(culture, tableLayoutPanel1);
            loadDataFromCulture(culture, tableLayoutPanel4);
            loadDataFromCulture(culture, tableLayoutPanel5);
            loadDataFromCulture(culture, tableLayoutPanel6);
        }

        private void loadDataFromCulture(MBBannerlordCulture culture, TableLayoutPanel tableLayoutPanel)
        {
            var propertiesInfos = culture.GetType().GetProperties();
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                var control = tableLayoutPanel.GetControlFromPosition(0, i);

                if (control == null)
                    continue;

                var controlName = tableLayoutPanel.GetControlFromPosition(0, i).Text;
                var searchResult = propertiesInfos.Where(o => o.Name == controlName.ToLower());
                if (searchResult.Count() == 1)
                {
                    var textBoxControl = tableLayoutPanel.GetControlFromPosition(1, i);
                    var objectVal = searchResult.First().GetValue(culture);
                    if (objectVal != null)
                    {
                        textBoxControl.Text = objectVal.ToString();
                    }
                }
            }
        }

        #region Name Builders

        private void btnAddMaleName_Click(object sender, EventArgs e)
        {
            frmValueInputer maleNameEditorWin = new frmValueInputer("Male Name");
            if(maleNameEditorWin.ShowDialog() == DialogResult.OK)
            {
                maleNamesList.Items.Add(maleNameEditorWin.Value);
            }
        }

        private void btnDeleteMaleName_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Helper.LOC("str_info_message_do_you_want_to_delete_this"), 
                Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                maleNamesList.Items.Remove(maleNamesList.SelectedItem);
            }
        }

        private void btnModifyMaleName_Click(object sender, EventArgs e)
		{
			frmValueInputer maleNameEditorWin = new frmValueInputer("Male Name", maleNamesList.SelectedItem.ToString());
			if (maleNameEditorWin.ShowDialog() == DialogResult.OK)
			{
				maleNamesList.Items.Add(maleNameEditorWin.Value);
			}
		}

        private void btnAddFemaleName_Click(object sender, EventArgs e)
		{
			frmValueInputer femaleNameEditorWin = new frmValueInputer("Female Name");
			if (femaleNameEditorWin.ShowDialog() == DialogResult.OK)
			{
				femaleNamesList.Items.Add(femaleNameEditorWin.Value);
			}
		}

        private void btnDeleteFemaleName_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(
				Helper.LOC("str_info_message_do_you_want_to_delete_this"),
				Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				== DialogResult.Yes)
			{
				femaleNamesList.Items.Remove(femaleNamesList.SelectedItem);
			}
		}

        private void btnModifyFemaleName_Click(object sender, EventArgs e)
		{
			frmValueInputer femaleNameEditorWin = new frmValueInputer("Female Name", femaleNamesList.SelectedItem.ToString());
			if (femaleNameEditorWin.ShowDialog() == DialogResult.OK)
			{
				femaleNamesList.Items.Add(femaleNameEditorWin.Value);
			}
		}

        private void btnAddClanName_Click(object sender, EventArgs e)
		{
			frmValueInputer clanNameEditorWin = new frmValueInputer("Clan Name");
			if (clanNameEditorWin.ShowDialog() == DialogResult.OK)
			{
				clanNamesList.Items.Add(clanNameEditorWin.Value);
			}
		}

        private void btnDeleteClanName_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(
				Helper.LOC("str_info_message_do_you_want_to_delete_this"),
				Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				== DialogResult.Yes)
			{
				clanNamesList.Items.Remove(clanNamesList.SelectedItem);
			}
		}

        private void btnModifyClanName_Click(object sender, EventArgs e)
		{
			frmValueInputer clanNameEditorWin = new frmValueInputer("Clan Name", clanNamesList.SelectedItem.ToString());
			if (clanNameEditorWin.ShowDialog() == DialogResult.OK)
			{
				clanNamesList.Items.Add(clanNameEditorWin.Value);
			}
		}

		private void femaleNamesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (femaleNamesList.SelectedIndex > 0)
			{
				btnDeleteFemaleName.Enabled = true;
				btnModifyFemaleName.Enabled = true;
			}
			else
			{
				btnDeleteFemaleName.Enabled = false;
				btnModifyFemaleName.Enabled = false;
			}
		}

		private void clanNamesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (clanNamesList.SelectedIndex > 0)
			{
				btnDeleteClanName.Enabled = true;
				btnModifyClanName.Enabled = true;
			}
			else
			{
				btnDeleteClanName.Enabled = false;
				btnModifyClanName.Enabled = false;
			}
		}

		#endregion

		private void btnSave_Click(object sender, EventArgs e)
        {
			culture.armed_trader = txtArmedTrader.Text;
			culture.armorer = txtArmorer.Text;
			culture.artisan_notary = txtArtisanNotary.Text;
			culture.barber = txtBarber.Text;
			culture.basic_troop = txtBasicTroop.Text;
			culture.beggar = txtBeggar.Text;
			culture.blacksmith = txtBlackmith.Text;
			culture.board_game_type = txtBoardGameType.Text;
			culture.can_have_settlement = chkCanHaveSettlement.Checked.ToString();
			culture.caravan_guard= txtCaravanGuard.Text;
			culture.caravan_master= txtCaravanMaster.Text;
			culture.caravan_party_template = txtCaravanPartyTemplate.Text;
			culture.ClanNames = new List<MBCultureName>();
			foreach(var item in clanNamesList.Items)
			{
				culture.ClanNames.Add(new MBCultureName() { name = item.ToString() });
			}
			culture.color = txtColor.Text;
			culture.color2 = txtColor2.Text;
			culture.default_face_key = txtDefaultFaceKey.Text;
			culture.default_party_template = txtDefaultPartyTemplate.Text;
			culture.duel_preset = txtDuelPreset.Text;
			culture.elite_basic_troop = txtEliteBasicTroop.Text;
			culture.elite_caravan_party_template = txtEliteCaravanPartyTemplate.Text;
			culture.encounter_background_mesh = txtEncounterBackgroundMesh.Text;
			culture.FemaleNames = new List<MBCultureName>();
			foreach(var item in femaleNamesList.Items)
			{
				culture.FemaleNames.Add(new MBCultureName() { name = item.ToString() });
			}
			culture.female_beggar = txtFemaleBeggar.Text;
			culture.female_dancer = txtFemaleDancer.Text;
			culture.gangleader_bodyguard = txtGangleaderBodyGuard.Text;
			culture.gear_dummy = txtGearDummy.Text;
			culture.gear_practice_dummy = txtGearPracticeDummy.Text;
			culture.guard = txtGuard.Text;
			culture.horseMerchant = txtHorseMerchant.Text;
			culture.id = txtID.Text;
			culture.is_main_culture = chkIsMainCulture.Checked.ToString();
			culture.MaleNames = new List<MBCultureName>();
			foreach(var item in maleNamesList.Items)
			{
				culture.MaleNames.Add(new MBCultureName() { name = item.ToString() });
			}
			culture.melee_elite_militia_troop = txtMeleeEliteMilitiaTroop.Text;
			culture.melee_militia_troop = txtMeleeMilitiaTroop.Text;
			culture.merchant = txtMerchant.Text;
			culture.merchant_notary = txtMerchantNotary.Text;
			culture.militia_party_template = txtMilitiaPartyTemplate.Text;
			culture.musician = txtMusician.Text;
			culture.name = txtName.Text;
			culture.preacher_notary = txtPreacherNotary.Text;
			culture.prison_guard = txtPrisonGuard.Text;
			culture.prosperity_bonus = txtProsperityBonus.Text;
			culture.ranged_elite_militia_troop = txtRangedEliteMilitaTroop.Text;
			culture.ranged_militia_troop = txtRangedMilitiaTroop.Text;
			culture.ransom_broker = txtRansomBroker.Text;
			culture.rebels_party_template = txtRebelsPartyTemplate.Text;
			culture.rural_notable_notary = txtRuralNotableNotary.Text;
			culture.shop_worker = txtShopWorker.Text;
			culture.steward = txtSteward.Text;
			culture.taverngamehost = txtTavernGameHost.Text;
			culture.tavernkeeper = txtTarvenkeeper.Text;
			culture.tavern_wench = txtTavernWench.Text;
			culture.text = txtText.Text;
			culture.tournament_master = txtTournamentMaster.Text;
			
			culture.tournament_team_templates_one_participant = new List<MBCultureTemplateName>();
			string[] tokens = txtTornamentTeamTemplatesOneParticipant.Text.Split(',');
			foreach(var token in tokens )
			{
				culture.tournament_team_templates_one_participant.Add(new MBCultureTemplateName() { name = token });
			}
			
			culture.tournament_team_templates_two_participant = new List<MBCultureTemplateName>();
			tokens = txtTornamentTeamTemplatesTwoParticipant.Text.Split(',');
			foreach (var token in tokens)
			{
				culture.tournament_team_templates_two_participant.Add(new MBCultureTemplateName() { name = token });
			}
			
			culture.tournament_team_templates_three_participant = new List<MBCultureTemplateName>();
			tokens = txtTornamentTeamTemplatesThreeParticipant.Text.Split(',');
			foreach (var token in tokens)
			{
				culture.tournament_team_templates_three_participant.Add(new MBCultureTemplateName() { name = token });
			}
			
			culture.tournament_team_templates_four_participant = new List<MBCultureTemplateName>(); 
			tokens = txtTornamentTeamTemplatesFourParticipant.Text.Split(',');
			foreach (var token in tokens)
			{
				culture.tournament_team_templates_four_participant.Add(new MBCultureTemplateName() { name = token });
			}
			
			culture.townsman = txtTownsman.Text;
			culture.townsman_child = txtTownsmanChild.Text;
			culture.townsman_infant = txtTownsmanInfant.Text;
			culture.townsman_teenager = txtTownsmanTeenager.Text;
			culture.townswoman = txtTownswoman.Text;
			culture.townswoman_child = txtTownswomanChild.Text;
			culture.townswoman_infant = txtTownswomanInfant.Text;
			culture.townswoman_teenager = txtTownswomanTeenager.Text;
			culture.town_edge_number = txtTownEdgeNumber.Text;
			culture.veteran_caravan_guard = txtVeteranCaravanGuard.Text;
			culture.villager = txtVillager.Text;
			culture.villager_female_child = txtVillagerFemaleChild.Text;
			culture.villager_female_teenager = txtVillagerFemaleTeenager.Text;
			culture.villager_male_child = txtVillagerMaleChild.Text;
			culture.villager_male_teenager = txtVillagerMaleTeenager.Text;
			culture.villager_party_template = txtVillagerPartyTemplate.Text;
			culture.village_woman = txtVillageWoman.Text;
			culture.weaponsmith = txtWeaponSmith.Text;
			culture.weapon_practice_stage_1 = txtWeaponPracticeStage1.Text;
			culture.weapon_practice_stage_2 = txtWeaponPracticeStage2.Text;
			culture.weapon_practice_stage_3 = txtWeaponPracticeStage3.Text;

			btnSave.Enabled = false;

			SaveCultureInfoFinished?.Invoke(culture, addEditState, index);

		}

		private void maleNamesList_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (maleNamesList.SelectedIndex > 0)
            {
                btnDeleteMaleName.Enabled = true;
                btnModifyMaleName.Enabled = true;
            }
            else
			{
				btnDeleteMaleName.Enabled = false;
				btnModifyMaleName.Enabled = false;
			}
		}
	}
}
