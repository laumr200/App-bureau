   M S B A M L   `   `   `  ����S  OGestionPersonnelMedicale, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:GestionPersonnelMedicaleGestionPersonnelMedicale  5      3    -GestionPersonnelMedicale.Departementrecherche   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:GestionPersonnelMedicale     5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Departement��6   $	��150��6*   $��0��66   $��Center=�6F   $��16(�6a   �� 5      -   5         ��Name$ 	txtSearch��5      $��1��6)   $��5,0,0,0q�69   $"��Entrez le nom du departement��6J   $��Center=�6n   $��16(�6�   �� 5      -   5         ��Name$
 btn7��5   �   $��
Rechercher��6   $��2��6*   $��5,0,0,0q�6:   $��Center=�6f   $��16(�6�   6�   5       &   System.Windows.Controls.DataGrid  5"   
      AutoGenerateColumns$
 True��69   $��10,10,10,138q�6T   $��1��6j   ��6   �� *SearchResults+6j   � 5#   
   $��2��6   .+�5$      �� -   5        $
 btn6��5$   �   $��Retourer��6   $��249,10,0,10q�6)   $
��Left=�6Z   $��79��6u    J� RenderTransformOrigin$ 1.491,0.617&�6�   �� 5%      -   5        $
 btn5��5%   n   $��	Francais ��6   $	��100��6)   $��30��65   $��548,10,0,10q�6A   $
��Left=�6|   �� 5&      -   5        $
 btn4��5&   X   $��Anglais��6   $	��100��6'   $��30��63   $��10q�6f   $��Center=�6r   $��1��6�   5'      5)      5+      