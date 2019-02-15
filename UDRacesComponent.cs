using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public class UDRacesComponent : LogicComponent
    {
        private readonly LiveSplitState _state;

        public override string ComponentName => "Ultime Décathlon Races";

        public UDRacesComponent(LiveSplitState state)
        {
            this._state = state;
            this.ContextMenuControls = new Dictionary<string, Action>();
            this.ContextMenuControls.Add("UD Races...", new Action(() =>
                {
                    MessageBox.Show("Coucou");
                }));
        }

        public override void Dispose()
        {
           
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            throw new NotImplementedException();
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            throw new NotImplementedException();
        }

        public override void SetSettings(XmlNode settings)
        {
            throw new NotImplementedException();
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            
        }
    }
}
