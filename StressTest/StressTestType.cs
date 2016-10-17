using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StressTest
{
    public class StressTestType:INotifyPropertyChanged
    {
        private Material selectedMaterial;
        private TestResult selectedResult;
        private CrossSection seletedCrossSection;

        public event PropertyChangedEventHandler PropertyChanged;

        public Array Material
        {
            get { return Enum.GetValues(typeof(Material)); }
        }

        public Array TestResult
        {
            get { return Enum.GetValues(typeof(TestResult)); }
        }

        public Array CrossSection
        {
            get { return Enum.GetValues(typeof(CrossSection)); }
        }

        public Material SelectedMaterial
        {
            get { return selectedMaterial; }
            set
            {
                selectedMaterial = value;
                OnChange("SelectedMaterial");
                
            }
        }

        public TestResult SelectedResult
        {
            get { return selectedResult; }
            set
            {
                selectedResult = value;
                OnChange("SelectedResult");

            }
        }

        public CrossSection SeletedCrossSection
        {
            get { return seletedCrossSection; }
            set
            {
                seletedCrossSection = value;
                OnChange("SeletedCrossSection");

            }
        }

        public void OnChange(string propname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propname));
            }
        }

       



    }
}
