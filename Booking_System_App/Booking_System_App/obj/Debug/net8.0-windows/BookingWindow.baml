   M S B A M L   `   `   `  ����M  IBooking_System_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Booking_System_AppBooking_System_App  5   	   &     Booking_System_App.BookingWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Booking_System_App     5   	     � Title$  BookingWindow��5   	   $	��450��6   $	��800��6,   
�������.��5	      � .+�5
   
   � $��10q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      �� $��Manage a Booking��6   $��24(�5      $
��Bold"�5      $��Center=�5      �� 5      -   5         ��Name$ BookingListView��5      $��1��60   $��0,0,0,10q�6=    �� SelectionMode$ Single=�6O    �� View 5      �� 5      .P�5      �� $��Room Number��6)    �� Width$	 120��6j    �� DisplayMemberBinding 6>   �� *
RoomNumber+6j   �� 5      $��	Room Type��6)   $	 150��6f    6<   �� *
RoomType+6f   �� 5      $��Price per Night��6)   $	 120��6q    6B   �� *PricePerNight+6q   �� 5      $��Status��6)   $	 100��6a    69   �� *Status+6a   5      5      �� 5!      $��2��6    �� Orientation$ 
Horizontal=�6&   $��Center=�6?   $��0,10,0,0q�6\   .+�5"      �� -   5         ��Name$ 
BookButton��5"      $��	Book Room��6-   $	��100��6A   $��5q�6M   
��� � �
�������$
��Bold"�5#   3   5$      �� 5&      -   5        $ CancelButton��5&      $��Cancel Booking��6/   $	��120��6H   $��5q�6T   
���<��
�������$
��Bold"�5'   5   5(      5)      5,      5-      5.      