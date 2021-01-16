using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Final_Exam_OOP
{
    class ComplicatedPage: BasePage
    {
        public SectionOfButtons ButtonsSection { get; set; }
        public SectionOfSocialMedia SocialMediaSection { get; set; }
        public SectionOfRandomStuff RandomStuffSection { get; set; }
        public override string PageName { get=> "Complicated Page"; }


    }
}
