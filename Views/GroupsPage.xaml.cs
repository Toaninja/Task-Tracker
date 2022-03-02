using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Task_Tracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GroupsPage : Page
    {
        public GroupsPage()
        {
            this.InitializeComponent();

            List<GroupsClass>  groupsCore = GroupDataBind();

            addGroup.Click += (object sender, RoutedEventArgs e) => { addGroup_Click(sender, e, groupsCore); };

            DatePickerCheck.SelectedDate = null;
        }

        public List<GroupsClass> GroupDataBind()
        {
            ServiceGroupBuilder groupBuilder = new ServiceGroupBuilder();

            List<GroupsClass> groupsCore = groupBuilder.groupsListBuilder();

            NavGroupsList.ItemsSource = groupsCore;

            return groupsCore;
        }

        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NavGroupsList_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void addNewGroup_Click(object sender, RoutedEventArgs e)
        {
            newGroupPopup.IsOpen = true;
            groupName.Focus(FocusState.Keyboard);
        }

        private void addGroup_Click(object sender, RoutedEventArgs e, List<GroupsClass> groupsCore)
        {
            GroupsClass temp = new GroupsClass();

            


            if (groupName.Text == "")
            {
                groupName.PlaceholderText = "Cannot be blank!";
            }
            else
            {
               
                temp.name = groupName.Text;
                groupsCore.Add(temp);
                newGroupPopup.IsOpen = false;

                groupName.Text = "";
                

                // To update the gridview, a cheap way to do it is null the source then set it back to groupsCore, thus adding the new item
                NavGroupsList.ItemsSource = null;
                NavGroupsList.ItemsSource = groupsCore;
            }
            
            
        }

        private void OnKeyDownHandler(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                
            }
            
        }
    }
}
