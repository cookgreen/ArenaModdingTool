using ArenaModdingTool.ModdingFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaModdingTool.Forms
{
    public partial class frmNPCCharacterFaceEditor : Form
    {
        private MBBannerlordNPCCharacter character;
        private AMProject project;
        private MBNPCCharacterFace characterFace;
        public MBNPCCharacterFace CharacterFace
        {
            get { return characterFace; }
        }

        public frmNPCCharacterFaceEditor(AMProject project, MBBannerlordNPCCharacter character)
        {
            InitializeComponent();
            this.character = character;
            this.project = project;

            if (character.Face != null)
            {
                if (character.Face.face_key_template != null)
                {
                    rbUseFaceKeyTemplate.Checked = true;
                    txtFaceKeyTemplate.Text = character.Face.face_key_template.value;
                }
                else
                {
                    rbDonotUseFaceKeyTemplate.Checked = true;
                    if (character.Face.BodyProperties != null)
                    {
                        txtBodyPropertiesAge.Text = character.Face.BodyProperties.age;
                        txtBodyPropertiesBuild.Text = character.Face.BodyProperties.build;
                        txtBodyPropertiesKey.Text = character.Face.BodyProperties.key;
                        txtBodyPropertiesVersion.Text = character.Face.BodyProperties.version;
                        txtBodyPropertiesWeight.Text = character.Face.BodyProperties.weight;
                    }
                    chkUseBodyPropertiesMax.Checked = character.Face.BodyPropertiesMax != null;
                    if (chkUseBodyPropertiesMax.Checked)
                    {
                        txtBodyPropertiesMaxAge.Text = character.Face.BodyPropertiesMax.age;
                        txtBodyPropertiesMaxBuild.Text = character.Face.BodyPropertiesMax.build;
                        txtBodyPropertiesMaxKey.Text = character.Face.BodyPropertiesMax.key;
                        txtBodyPropertiesMaxVersion.Text = character.Face.BodyPropertiesMax.version;
                        txtBodyPropertiesMaxWeight.Text = character.Face.BodyPropertiesMax.weight;
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            characterFace = new MBNPCCharacterFace();
            if (rbUseFaceKeyTemplate.Checked)
            {
                characterFace.face_key_template = new MBSubModuleInfoElement();
                characterFace.face_key_template.value = txtFaceKeyTemplate.Text;
            }
            else if (rbDonotUseFaceKeyTemplate.Checked)
            {
                characterFace.BodyProperties = new MBNPCCharacterBody();
                characterFace.BodyProperties.age = txtBodyPropertiesAge.Text;
                characterFace.BodyProperties.build = txtBodyPropertiesBuild.Text;
                characterFace.BodyProperties.key = txtBodyPropertiesKey.Text;
                characterFace.BodyProperties.version = txtBodyPropertiesVersion.Text;
                characterFace.BodyProperties.weight = txtBodyPropertiesWeight.Text;

                if (chkUseBodyPropertiesMax.Checked)
                {
                    characterFace.BodyPropertiesMax = new MBNPCCharacterBody();
                    characterFace.BodyPropertiesMax.age = txtBodyPropertiesMaxAge.Text;
                    characterFace.BodyPropertiesMax.build = txtBodyPropertiesMaxBuild.Text;
                    characterFace.BodyPropertiesMax.key = txtBodyPropertiesMaxKey.Text;
                    characterFace.BodyPropertiesMax.version = txtBodyPropertiesMaxVersion.Text;
                    characterFace.BodyPropertiesMax.weight = txtBodyPropertiesMaxWeight.Text;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkUseBodyPropertiesMax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseBodyPropertiesMax.Checked)
            {
                txtBodyPropertiesMaxAge.Enabled = true;
                txtBodyPropertiesMaxBuild.Enabled = true;
                txtBodyPropertiesMaxKey.Enabled = true;
                txtBodyPropertiesMaxVersion.Enabled = true;
                txtBodyPropertiesMaxWeight.Enabled = true;
            }
            else
            {
                txtBodyPropertiesMaxAge.Enabled = false;
                txtBodyPropertiesMaxBuild.Enabled = false;
                txtBodyPropertiesMaxKey.Enabled = false;
                txtBodyPropertiesMaxVersion.Enabled = false;
                txtBodyPropertiesMaxWeight.Enabled = false;
            }
        }

        private void rbUseFaceKeyTemplate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUseFaceKeyTemplate.Checked)
            {
                txtFaceKeyTemplate.Enabled = true;
                txtBodyPropertiesAge.Enabled = false;
                txtBodyPropertiesBuild.Enabled = false;
                txtBodyPropertiesKey.Enabled = false;
                txtBodyPropertiesVersion.Enabled = false;
                txtBodyPropertiesWeight.Enabled = false;

                chkUseBodyPropertiesMax.Checked = false;
            }
            else
            {
                txtFaceKeyTemplate.Enabled = false;
                txtBodyPropertiesAge.Enabled = true;
                txtBodyPropertiesBuild.Enabled = true;
                txtBodyPropertiesKey.Enabled = true;
                txtBodyPropertiesVersion.Enabled = true;
                txtBodyPropertiesWeight.Enabled = true;

                chkUseBodyPropertiesMax.Checked = true;
            }
        }

        private void txtFaceKeyTemplate_DoubleClick(object sender, EventArgs e)
        {
            frmNPCCharacterListViewer characterListViewer = new frmNPCCharacterListViewer(project);
            if (characterListViewer.ShowDialog() == DialogResult.OK)
            {
                txtFaceKeyTemplate.Text = "NPCCharacters." + characterListViewer.SelectedCharacter.id;
            }
        }

        private void rbDonotUseFaceKeyTemplate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUseFaceKeyTemplate.Checked)
            {
                txtFaceKeyTemplate.Enabled = true;
                txtBodyPropertiesAge.Enabled = false;
                txtBodyPropertiesBuild.Enabled = false;
                txtBodyPropertiesKey.Enabled = false;
                txtBodyPropertiesVersion.Enabled = false;
                txtBodyPropertiesWeight.Enabled = false;

                chkUseBodyPropertiesMax.Checked = false;
            }
            else
            {
                txtFaceKeyTemplate.Enabled = false;
                txtBodyPropertiesAge.Enabled = true;
                txtBodyPropertiesBuild.Enabled = true;
                txtBodyPropertiesKey.Enabled = true;
                txtBodyPropertiesVersion.Enabled = true;
                txtBodyPropertiesWeight.Enabled = true;

                chkUseBodyPropertiesMax.Checked = true;
            }
        }
    }
}
