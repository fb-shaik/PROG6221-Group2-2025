   M S B A M L   `   `   `  ����M  IBooking_System_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Booking_System_AppBooking_System_App  5   	   #    Booking_System_App.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Booking_System_App     5   	     � Title$  Booking App - Main Window��5   	   $	��467��6+   $	��800��68   
�������.��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $'��!Welcome to the Booking System App��6   $��24(�5      $
��Bold"�5      $��Center=�5      �� 5   
   -   5         ��Name$ RoomListView��5      $��1��6)   $��0,0,0,10q�66    �� SelectionMode$ Single=�6H    �� View 5      �� 5      .P�5      �� $��Room Number��6%    �� Width$	 120��6f    �� DisplayMemberBinding 6:   �� *
RoomNumber+6f   �� 5      $��	Room Type��6%   $	 150��6b    68   �� *
RoomType+6b   �� 5      $��Price per Night��6%   $	 120��6m    6>   �� *PricePerNight+6m   �� 5      $��Status��6%   $	 100��6]    65   �� *Status+6]   5      5      �� 5    
   -   5        $��2��5       $��Manage Bookings��6   $	��150��68   $��30��6D   $��Center=�5!      
������
���   �$
��Bold"�5"   8   5$      5%      