   M S B A M L   `   `   `  ����  tea shop app    tea_shop_app.view_emp   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  view_emp��5       N� 
Background
 �����.��5      � .+�5   
   �� $��Center=�6   .+�5      �� $��	employees��6   $	��100��6)   $��30��65   $��16(�6A   $��SemiBold"�6O   
���r���6e   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ employee_tetail��5   H   $	��250��6   $	��550��6       AutoGenerateColumns .  $��3q�6a   ���#d8e8dc � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow��%  '        '  �     �� 5      "  6   .�5      ��  � ��
 ���@�64   �� 5       � ��
 �   �64   �� 5       � ��$ SemiBold"�63   �� 5       � ��$ 1q�68   5      �� 5      "  6   .�5      ��  � �� �#c3ebc863   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Empid��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 40 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Empid+  5       $
	 Name��6%   $
 * 63    6=   �� *Name+  5!      $		 Dob��6%   $
 * 62    6<   �� *Dob+  5"      $	 Phone��6%   $
 * 64    6>   �� *Phone+  5#      $
	 Type��6%   $
 * 63    6=   �� *Type+  5$      $	 Email��6%   $
 * 64    6>   �� *Email+5&      5'      5(      