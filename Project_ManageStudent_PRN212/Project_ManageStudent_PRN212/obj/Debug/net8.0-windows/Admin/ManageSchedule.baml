   M S B A M L   `   `   `  ����   Project_ManageStudent_PRN2127    1Project_ManageStudent_PRN212.Admin.ManageSchedule   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Manage Schedule��5   	   $	��600��6!   $
��1000��6.    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Schedule Management��6   $��24(�5      $
��Bold"�5      $��Center=�5      $��0,0,0,20q�5      �� 5   
   $��1��6   $��0,0,0,20q�6"   .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��0��6   $��5q�6-   .+�5      �� $��Class:��6    $��0,0,0,5q�6.   �� 5       -   5         ��Name$ cbbClass��5       $��0,0,0,10q�61   5!      �� 5#      $��1��6   $��5q�6-   .+�5$      �� $
��Day:��6    $��0,0,0,5q�6,   �� 5%      -   5        $ cbbDayOfWeek��5%      $��0,0,0,10q�65   .@�5&      �� .��6'   Monday6/   �� 5'      .��6'   	Tuesday60   �� 5(      .��6'   	Wednesday62   �� 5)      .��6'   
Thursday61   �� 5*      .��6'   Friday6/   �� 5+      .��6'   
Saturday61   �� 5,      .��6'   Sunday6/   5-      5.      �� 50      $��2��6   $��5q�6-   .+�51      �� $��
Time Slot:��6    $��0,0,0,5q�62   �� 52      -   5        $ cbbSlot��52      $��0,0,0,10q�60   .@�53      �� .��6'   07:30 - 09:0066   �� 54      .��6'   09:10 - 10:4066   �� 55      .��6'   10:50 - 12:2066   �� 56      .��6'   12:50 - 14:2066   �� 57      .��6'   14:30 - 16:0066   �� 58      .��6'   16:10 - 17:4066   59      5:      5;      �� 5=       �� Orientation$ 
Horizontal=�6   $��Center=�62   $
��0,10q�6O   .+�5>      �� -   5         ��Name$ btnAdd��5>      $	��Add��6)   $	��100��67   $��5q�6C   6N   �� 5?      -   5        $ 	btnUpdate��5?      $��Update��6,   $	��100��6=   $��5q�6I   6T   �� 5@      -   5        $ 	btnDelete��5@      $��Delete��6,   $	��100��6=   $��5q�6I   6T   �� 5A      -   5        $ 	btnExport��5A      $��Export��6,   $	��100��6=   $��5q�6I   6T   5B      5C      &   System.Windows.Controls.DataGrid  5F   
   -   5          Name$ 
dgSchedule��5F      $��2��5G         AutoGenerateColumns$ False��5H      	   
IsReadOnly$
	 True��5I      
   SelectionMode$
 Single=�5J      $��0,0,0,20q�5L         Columns 5M      0  *System.Windows.Controls.DataGridTextColumn  5N      ,  &System.Windows.Controls.DataGridColumn   Header$ Class��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5O      �� *Class.ClassName+  5P      $ Course��6%    5Q      �� *Class.Course.CourseName+  5R      $ TeacherName��6%    5S      �� *Class.Teacher.TeacherName+  5T      $ RoomName��6%    5U      �� *Class.Room.RoomName+  5V      $ DayOfWeekString��6%    5W      �� *DayOfWeekString+  5X      $
 Slot��6%    5Y      �� *
SlotString+5[      �� 5^   
   -	   5        $ btnBack��5_      $��3��5^      $
��Back��5`      $	��100��5a      $��Right=�5b      5c      5d      5e      