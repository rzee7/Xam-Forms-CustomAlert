# Xam-Forms-CustomAlert
Custom alert in Xamarin Forms.

# Usage:

- Binding Values From ViewModel:

        xmlns:control="clr-namespace:CustomAlert.Controls;assembly=CustomAlert"

        <control:AlertView AlertTitle="{Binding Title}"
                           AlertType="{Binding Alert}"
                           Description="{Binding Description}"
                           HasPositiveButton="{Binding HasPositiveButton}"
                           IsVisible="{Binding IsAlert,
                                               Mode=TwoWay}"
                           NegativeButtonTitle="Cancel"
                           OnCommand="{Binding OnAlertCommand}"
                           PositiveButtonTitle="Proceed" />
                           
- Direct Values Init:

        <control:AlertView AlertTitle="Updated"
                                   AlertType="Success"
                                   Description="Here is description."
                                   HasPositiveButton="True"
                                   IsVisible="{Binding IsAlert,
                                                       Mode=TwoWay}"
                                   NegativeButtonTitle="Cancel"
                                   OnCommand="{Binding OnAlertCommand}"
                                   PositiveButtonTitle="Proceed" />
                           
# Android:
![Android](https://raw.githubusercontent.com/rzee7/Xam-Forms-CustomAlert/master/Screenshots/Droid.png)

# iOS:
![iOS](https://raw.githubusercontent.com/rzee7/Xam-Forms-CustomAlert/master/Screenshots/iOS.png)

> Note: This is only few hours work, not perfect but yes! It is good start. Most Welcome, If you want to Contribute into it.



