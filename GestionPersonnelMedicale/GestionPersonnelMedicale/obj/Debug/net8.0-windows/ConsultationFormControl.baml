   M S B A M L   `   `   `  ����S  OGestionPersonnelMedicale, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:GestionPersonnelMedicaleGestionPersonnelMedicale  5      6    0GestionPersonnelMedicale.ConsultationFormControl   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:GestionPersonnelMedicale     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $
��ID :��6   $��0��6   $��0��6,   $	��Top=�6<   $��10q�6T   
�������6`   �� 5   
   -   5         ��Name$ 	IDTextBox��5      $��0��6^   $��1��6k   $	��Top=�6{   $��	10,5,10,5q�6�   ��6%   �� *ID+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��	Patient :��6   $��1��6$   $��0��61   $	��Top=�6A   $��10q�6Y   
�������6e   �� 5   
   -   5        $ PatientTextBox��5      $��1��6h   $��1��6u   $	��Top=�6�   $��	10,5,10,5q�6�   ��6*   �� *	Patient+$ PropertyChanged=�6�   �� 5    
   $��Date :��6   $��2��6!   $��0��6.   $	��Top=�6>   $��10q�6V   
�������6b   (  "System.Windows.Controls.DatePicker  5!   
   -   5          Name$ 
DatePicker��5!      $��2��6G   $��1��6T   $	��Top=�6d   $��	10,5,10,5q�6|      SelectedDate 6)   �� *Date+6|   �� 5$   
   $��Heure :��6   $��3��6"   $��0��6/   $	��Top=�6?   $��10q�6W   
�������6c   �� 5%   
   -   5        $ HeureTextBox��5%      $��3��6d   $��1��6q   $	��Top=�6�   $��	10,5,10,5q�6�   ��6(   �� *Heure+$ PropertyChanged=�6�   �� 5(   
   $��Observations :��6   $��4��6)   $��0��66   $	��Top=�6F   $��10q�6^   
�������6j   �� 5)   
   -   5        $ ObservationsTextBox��5)      $��4��6r   $��1��6   $	��Top=�6�   $��	10,5,10,5q�6�   ��6/   �� *Observations+$ PropertyChanged=�6�   �� 5,   
    �� Orientation$ 
Horizontal=�6   $��5��6.   $
��Left=�6;   $��63,77,0,179q�6V   $��1��6k   .+�5-      �� -   5         ��Name$
 btn7��5-   \   $��Sauvegarder��6   $	��100��6+   $��5q�67   6\   �� 5.      -   5        $
 btn6��5.   Y   $��	Retourner��6   $	��100��6)   $��5q�65   6Y   �� 5/      -   5        $
 btn5��5/   Y   $��	Francais ��6   $	��100��6)   $��5q�66   $��1��6g   �� 50      -	   5        $
 btn4��50   M   $��Anglais��6   $	��100��6'   $��5q�6[   $��1��6f   52      53      54      