using ArenaModdingTool.ModdingFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaModdingTool.Controls
{
    public class ucNPCCharacterList : UserControl
    {
        private TreeView npcCharacterList;
        private MBNPCCharacters npcCharacters;
        private MBNPCCharacter selectedCharacter;
        public event Action<MBNPCCharacter, int> SelectNPCCharacterChanged;
        public MBNPCCharacter SelectedCharacter
        {
            get { return selectedCharacter; }
        }

        private void InitializeComponent()
        {
            this.npcCharacterList = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // npcCharacterList
            // 
            this.npcCharacterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.npcCharacterList.Location = new System.Drawing.Point(0, 0);
            this.npcCharacterList.Name = "npcCharacterList";
            this.npcCharacterList.Size = new System.Drawing.Size(184, 410);
            this.npcCharacterList.TabIndex = 0;
            this.npcCharacterList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // ucNPCCharacterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.npcCharacterList);
            this.Name = "ucNPCCharacterList";
            this.Size = new System.Drawing.Size(184, 410);
            this.ResumeLayout(false);

        }

        public ucNPCCharacterList(MBNPCCharacters npcCharacters)
        {
            InitializeComponent();
            this.npcCharacters = npcCharacters;
            loadNPCCharacters();
        }

        private void loadNPCCharacters()
        {
            npcCharacterList.Nodes.Clear();
            foreach (var npcCharacter in npcCharacters.NPCCharacters)
            {
                npcCharacterList.Nodes.Add(npcCharacter.name);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                int index = npcCharacterList.Nodes.IndexOf(e.Node);
                selectedCharacter = npcCharacters.NPCCharacters[index];
                SelectNPCCharacterChanged?.Invoke(npcCharacters.NPCCharacters[index], index);
            }
        }
    }
}
