   M S B A M L   `   `   `  ����S  OGestionPersonnelMedicale, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:GestionPersonnelMedicaleGestionPersonnelMedicale  5      3    -GestionPersonnelMedicale.ModifierConsultation   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:GestionPersonnelMedicale     5      .��5	      � ��5
   
   �� 5        �� ImageSource$+  %/Gestion-Absences-Retardslogocapa.png��6    �� Opacity$	 0.8Q�6M    j� Stretch$ UniformToFill=�6[    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $2��,Modifier les Informations de la Consultation��6   $��18(�5      $
��Bold"�6   $��0,0,0,10q�6"   $��Center=�5      �� 5   
   $��1��6   $��10q�6"   .+�5      �� $	��300��5      $	��0,5q�6   ��5      �� *ID+ �� Mode$ TwoWay=�5      �� 5      $	��300��5      $	��0,5q�6   ��5      �� *	MedecinID+$ TwoWay=�5      �� 5      $	��300��5       $	��0,5q�6   ��5      �� *	Patient+$ TwoWay=�5       �� 5!      $	��300��5"      $	��0,5q�6   ��5!      �� *Date+$ TwoWay=�5"      �� 5#      $	��300��5$      $	��0,5q�6   ��5#      �� *Heure+$ TwoWay=�5$      �� 5%      $	��300��5&      $	��0,5q�6   ��5%      �� *Observations+$ TwoWay=�5&      5(      �� 5+   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��2��6K   .+�5,      �� -   5         ��Name$
 btn1��5,   ]   $��Enregistrer��6   $	��100��6+   $��5q�67   6]   �� 5-      -   5        $
 btn2��5-   U   $��Annuler��6   $	��100��6'   $��5q�63   6U   �� 5.      -   5        $
 btn3��5.   X   $��	Retourner��6   $	��100��6)   $��5q�65   6X   �� 5/      -   5        $
 btn4��5/   W   $��Anglais��6   $	��100��6'   $��5q�63   6W   �� 50      -   5        $
 btn5��50   X   $��	Francais ��6   $	��100��6)   $��5q�65   6X   51      53      54      