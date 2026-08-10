namespace Ivy.Tendril.Apps;

[App(title: "New Experience", icon: Icons.Sparkles, group: ["Apps"], order: Constants.NewExperience)]
public class NewExperienceApp : ViewBase
{
    public override object Build()
    {
        return Layout.Vertical().Padding(new Responsive<Thickness?> { Mobile = new Thickness(6, 0, 6, 0) })
               | (Layout.TopCenter()
                  | (Layout.Vertical().Margin(0, 20)
                     .Width(Size.Full().At(Breakpoint.Mobile).And(Breakpoint.Desktop, Size.Units(150)))
                     | Text.H1("New Experience")
                     | Text.Muted("Coming soon.")
                  )
               );
    }
}
