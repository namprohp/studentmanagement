   M S B A M L   `   `   `  ����   Project_ManageStudent_PRN212:    4Project_ManageStudent_PRN212.Student.StudentSchedule   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Student Schedule��5   	   $	��600��6"   $
��1000��6/    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��* �6   �� 5
      $
��Auto �6   .+�5   
   �� $��0��6   $��0,0,0,20q�6"   .+�5      �� $��My Schedule��6   $��24(�5      $
��Bold"�5      $��Center=�5      $��0,0,0,20q�5      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�5      $��0,0,0,10q�5      .+�5      �� -   5         ��Name$ 
btnRefresh��5      $��Refresh��5      $	��100��5      $	��5,0q�5      5      �� 5      -   5        $ 	btnExport��5      $��Export��5      $	��100��5      5       5!      5"      &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$ 
dgSchedule��5%      $��1��5&         AutoGenerateColumns$ False��5'         
IsReadOnly$
 True��5(      $��0,0,0,20q�5)         Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Course��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
CourseName+6T     5,      $	 Class��6%   $
 * 6R    64   �� *	ClassName+6R     5-      $	 Teacher��6%   $
 * 6V    66   �� *TeacherName+6V     5.      $
	 Room��6%   $
 * 6P    63   �� *
RoomName+6P     5/      $		 Day��6%   $
 * 6J    62   �� *Day+6J     50      $
	 Time��6%   $
 * 6L    63   �� *Time+6L   52      �� 55   
   -   5        $ btnBack��56      $��2��55      $
��Back��57      $	��100��58      $��Right=�59      5:      5;      5<      