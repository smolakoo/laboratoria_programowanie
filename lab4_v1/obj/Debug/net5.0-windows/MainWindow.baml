   M S B A M L   `   `   `  ����B  >lab4_v1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:lab4_v1lab4_v1  5   	       lab4_v1.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:lab4_v1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgStudenci��5
      $��	0,124,0,0q�6'      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Imię��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *imie+6L     5      $ Nazwisko��6%   $	 100 6T    67   �� *
nazwisko+6T     5      $ Numer indeksu��6%   $	 100 6S    6<   �� *id+6S     5      $ Wydział��6%   $ * 6R    66   �� *	wydzial+6R   5      �� 5   
   -   5         ��Name$ btnAdd��5      $��Dodaj studenta��6!   $
��Left=�6:   $��	27,57,0,0q�6U   $	��Top=�6h   6�   �� 5   
   -   5        $ btnRmv��5      $��Usuń studenta��6!   $
��Left=�69   $��
142,57,0,0q�6T   $	��Top=�6h   6�   5      5      