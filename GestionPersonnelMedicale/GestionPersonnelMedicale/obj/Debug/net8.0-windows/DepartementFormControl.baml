   M S B A M L   `   `   `  ����  GestionPersonnelMedicale5    /GestionPersonnelMedicale.DepartementFormControl   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $
��ID :��6   $��0��6   $��0��6,   $	��Top=�6<   $��10q�6T   
�������6`   �� 5   
   -   5         ��Name$ 	IDTextBox��5      $��0��5      $��1��6   $	��Top=�6/   $��	10,5,10,5q�6G   ��5   %   �� *ID+ �� UpdateSourceTrigger$ PropertyChanged=�5   G   �� 5   
   $��Nom du Département :��6   $��1��6/   $��0��6<   $	��Top=�6L   $��10q�6d   
�������6p   �� 5   
   -   5        $ 
NomTextBox��5      $��1��5       $��1��6   $	��Top=�6/   $��	10,5,10,5q�6G   ��5   &   �� *Nom+$ PropertyChanged=�5    G   �� 5#   
   $��Description :��6   $��2��6(   $��0��65   $	��Top=�6E   $��10q�6]   
�������6i   �� 5$   
   -   5        $ DescriptionTextBox��5$      $��2��5%      $��1��6   $	��Top=�6/   $��	10,5,10,5q�6G    �� AcceptsReturn$
 True��6Z   $��60��6o    �� TextWrapping$
 Wrap=�6{   ��5$   .   �� *Description+$ PropertyChanged=�5%   {   �� 5(   
   $��Localisation :��6   $��3��6)   $��0��66   $	��Top=�6F   $��10q�6^   
�������6j   �� 5)   
   -   5        $ LocalisationTextBox��5)      $��3��5*      $��1��6   $	��Top=�6/   $��	10,5,10,5q�6G   ��5)   /   �� *Localisation+$ PropertyChanged=�5*   G   �� 5/   
    �� Orientation$ 
Horizontal=�6   $��3��6.   $��1��6;   $
��Left=�6K   $��70,77,0,189q�6f   $	��484��6{   .+�50      �� -   5         ��Name$
 btn7��50   \   $��Sauvegarder��6   $	��100��6+   $��5q�67   6\   �� 51      -   5        $
 btn6��51   X   $��	Retourner��6   $	��100��6)   $��5q�65   6X   �� 52      -   5        $
 btn5��52   Y   $��	Francais ��6   $	��100��6)   $��5q�66   $��1��6g   �� 53      -   5        $
 btn4��53   M   $��Anglais��6   $	��100��6'   $��5q�6[   $��1��6f   55      56      57      