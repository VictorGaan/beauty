   M S B A M L   `   `   `  ����A  =Beauty, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BeautyBeauty  5   	       Beauty.ProductWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Beauty     5   	     � Title$  Окно товара��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66      DefaultWindow#��[  6[   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Right=�6   $��Center=�60   $��5q�6K   Наименование6d   �� 5   
   $��Right=�6   $��Center=�60   $��1��6K   $��5q�6X   
Цена6i   �� 5   
   $��Right=�6   $��Center=�60   $��2��6K   $��5q�6X   Описание6m   �� 5   
   $��Right=�6   $��Center=�60   $��3��6K   $��5q�6X   Активность6o   �� 5   
   $��Right=�6   $��Center=�60   $��4��6K   $��5q�6X   Производство6q   �� 5   
   $��1��6   $��Center=�6"   $��30��6D   $��5q�6P   ��6[   �� *Title+6t   �� 5   
   $��1��6   $��Center=�6"   $��30��6D   $��5q�6P   $��1��6q   ��6[   �� *Cost+6�   �� 5   
   $��1��6   $��Center=�6"   $��30��6D   $��5q�6P   $��2��6x   ��6[   �� *Description+6�   �� 5   
   $��3��6   $��1��6    $��Center=�60   $��5q�6K   $��Активность��6V    d� 	IsChecked 6k   �� *
IsActive+6�   �� 5   
   -   5        $��CmbManufacturies��5   H   $��4��6   $��1��6    $��30��60   $��5q�6=    �� DisplayMemberPath$
 Name��6`    �� SelectedItem 6y   �� *Manufacturer+6�   �� 5    
   -   5        $��BtnAdd��5    .   $��1��6   $��6��6!   $��30��6Q   .��6]   Добавить6g   5!      5"      