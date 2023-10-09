using ArenaModdingTool.ModdingFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlLoader;

namespace ArenaModdingTool.Controls
{
    public class ucNPCCharacterList : UserControl
    {
        private TreeView npcCharacterList;
        private MBBannerlordNPCCharacters npcCharacters;
        private MBBannerlordNPCCharacter selectedCharacter;
        public event Action<MBBannerlordNPCCharacter, int> SelectNPCCharacterChanged;
        public MBBannerlordNPCCharacter SelectedCharacter
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
			this.npcCharacterList.Size = new System.Drawing.Size(272, 410);
			this.npcCharacterList.TabIndex = 0;
			this.npcCharacterList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.npcCharacterList_AfterSelect);
			// 
			// ucNPCCharacterList
			// 
			this.Controls.Add(this.npcCharacterList);
			this.Name = "ucNPCCharacterList";
			this.Size = new System.Drawing.Size(272, 410);
			this.ResumeLayout(false);

        }

        public ucNPCCharacterList(MBBannerlordNPCCharacters npcCharacters)
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

        public void DeleteSelected()
        {
            if (npcCharacterList.SelectedNode != null)
            {
                int index = npcCharacterList.Nodes.IndexOf(npcCharacterList.SelectedNode);
                npcCharacters.NPCCharacters.RemoveAt(index);
                npcCharacterList.Nodes.RemoveAt(index);

                XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(npcCharacters.FilePath);
                xmlObjectLoader.Save(npcCharacters);

                RefreshData();
            }
        }

        public void RefreshData()
        {
            loadNPCCharacters();
        }

        private void npcCharacterList_AfterSelect(object sender, TreeViewEventArgs e)
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
