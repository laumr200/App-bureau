   M S B A M L   `   `   `  ����  GestionPersonnelMedicale1    +GestionPersonnelMedicale.MedecinFormControl   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5	      �   � RowDefinitions  5
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
   $��Nom :��6   $��1��6    $��0��6-   $	��Top=�6=   $��10q�6U   
�������6a   �� 5   
   -   5        $ 
NomTextBox��5      $��1��6`   $��1��6m   $	��Top=�6}   $��	10,5,10,5q�6�   ��6&   �� *Nom+$ PropertyChanged=�6�   �� 5    
   $��Spécialité :��6   $��2��6'   $��0��64   $	��Top=�6D   $��10q�6\   
�������6h   �� 5!   
   -   5        $ SpecialiteTextBox��5!      $��2��6n   $��1��6{   $	��Top=�6�   $��	10,5,10,5q�6�   ��6-   �� *
Specialite+$ PropertyChanged=�6�   �� 5$   
   $��Disponibilité :��6   $��3��6*   $��0��67   $	��Top=�6G   $��10q�6_   
�������6k   �� 5%   
   -   5         ��Name$ DisponibleCheckBox��5%      $��3��6P   $��1��6]   $	��Top=�6m   $��	10,5,10,5q�6�    d� 	IsChecked 6/   �� *
Disponible+6�   �� 5(   
   $��	Contact :��6   $��4��6$   $��0��61   $	��Top=�6A   $��10q�6Y   
�������6e   �� 5)   
   -   5        $ ContactTextBox��5)      $��4��6h   $��1��6u   $	��Top=�6�   $��
10,16,10,0q�6�   $��2��6�   ��6*   �� *	Contact+$ PropertyChanged=�6�   �� 5,   
   $��Département ID :��6   $��5��6+   $��0��68   $	��Top=�6H   $��
10,29,10,0q�6`   
�������6t   �� 5-   
   -   5        $ DepartementIDTextBox��5-      $��5��6t   $��1��6�   $	��Top=�6�   $��
10,23,10,0q�6�   ��60   �� *DepartementID+$ PropertyChanged=�6�   �� 50   
    �� Orientation$ 
Horizontal=�6   $��5��6.   $
��Left=�6;   $��146,78,0,178q�6V   $��1��6l   .+�51      �� -   5         ��Name$
 btn7��51   �   $�� Sauvegarder��6   $	��118��6,   $��5q�68   $��40��6]    J� RenderTransformOrigin$ 0.5,0.5&�6i   6�   �� 52      -   5        $
 btn6��52   e   $��
 Retourner��6   $	��118��6*   $��5q�66   $��40��6Y   6e   �� 53      -	   5        $
 btn5��53   Y   $��	Francais ��6   $	��100��6)   $��5q�66   $��1��6g   �� 54      -
   5        $
 btn4��54   M   $��Anglais��6   $	��100��6'   $��5q�6[   $��1��6f   56      57      58      