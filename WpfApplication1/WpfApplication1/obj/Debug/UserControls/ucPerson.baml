   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:WpfApplication1.Classes.Converters"WpfApplication1.Classes.Converters  5      1clr-namespace:WpfApplication1WpfApplication1  5      W0clr-namespace:WpfApplication1.Classes.Validaters"WpfApplication1.Classes.Validaters  5      +    %WpfApplication1.UserControls.ucPerson   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      G
Converters0clr-namespace:WpfApplication1.Classes.Converters     5      /localclr-namespace:WpfApplication1     5      G
Validaters0clr-namespace:WpfApplication1.Classes.Validaters     5        � 	Resources  5      <   6WpfApplication1.Classes.Converters.AgeToBrushConverter   ageToBrushConverter  SunsetRadiantBrush �� EndPoint �� 
StartPoint � Color � Offset��%�   &	        &	        5      6&   �� 5   
   $ 0.5,1&�69   $ 0.5,0&�6J   .��5      � $ Black��6   $ 0Q�6&   � 5      $ White��6   $ 1Q�6&   5      5      .��5      � #��[ 6    � ColumnDefinitions 5      �� 5      $��* �6   �� 5      $��2* �6    � RowDefinitions 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5       �� $��
_Prénom :��6
   $��3q�5!      $	��Top=�6   
������ �� Target 5       ��  �� ElementName$ 	txtPrenom��	 �� Mode$	 OneWay=�5!   '   �� 5"      -   5        
 ��Name$
 	txtPrenom��5"      $��1��6   $
��Left=�6/   $
��10 3q�6J    �� TextWrapping$
 Wrap=�5#      $
��Toto��6   $	��Top=�6$   $	��100��6<     textboxOrange#���  6H   �� 5$      $��1��6
   $��_Nom :��6   $��3q�5%      $	��Top=�6   
������ 5$   (   �� $ txtNom��$	 OneWay=�5%   '   �� 5&      -   5        $
 txtNom��5&      $��1��6   $��1��6,   $
��Left=�69   $
��10 3q�6T   $
 Wrap=�5'      $
��TOTO��6   $	��Top=�6$   #���  6<   $	��100��6i   �� 5(      $��2��6
   $��_Age :��6   $��3q�5)      $	��Top=�6   
������ 5(   (   �� $ txtAge��$	 OneWay=�5)   '   � 5*      -   5         �Name$ gridAge��5*   	   $��1��6   $��2��6*    5+      �� 5,      $��* �6   �� 5-      $��* �6   .+�5/      �� -   5        $
 txtAge��5/      $
��Left=�6&   $��0��6A   $
��10 3q�6Q   $
 Wrap=�50      $��Center=�6   #���  64   $	��100��51      ��6   �� *Text+ �� 	Converter# [  $ txtAge��.��6}   ��52      �� 53       �� Path$ Value�6    �� NotifyOnValidationError .  �� UpdateSourceTrigger$ PropertyChanged=�6J   $ 	sliderAge��6p    �� ValidationRules 54      5  /System.Windows.Controls.ExceptionValidationRule  55      8   2WpfApplication1.Classes.Validaters.NumberRangeRule  56      
   Min$ 0��69   
   Max$	 150��6A   ,  &System.Windows.Controls.ValidationRule   ValidationStep$ ConvertedProposedValue=�6K   58      .��59       5:      �� 5;      -   5         ��Name$ 	sliderAge��5;   %   $��1��6   $��10��68   $��80��6D   $
��Left=�6O   $��Center=�6j    � Maximum$	 150Q�6�    �� TickFrequency$ 1Q�6�    � SmallChange$ 1Q�5<       �� IsSnapToTickEnabled . $��
10,10,0,13q�6F    � Value 6   �� *Age+6F   5=      9� 5>      $��3��6   $��2��6   $��	Adresse :��6.   .��5?      �  5@      �� 5A      $��* �6   �� 5B      $��2* �6    5D      �� 5E      $
��Auto �6   �� 5F      $
��Auto �6   �� 5G      $
��Auto �6   .+�5I      �� $��0��6   $��_Voie :��6   $��3q�5J      $	��Top=�6   
������ 5I   +   �� $ txtVoie��$	 OneWay=�5J   )   �� 5K      -   5        $
 txtVoie��5K      $��1��6+   $��0��6;   $
��Left=�6H   $
��10 3q�6c   $
 Wrap=�5L      $	��Top=�6   #���  62   $	��100��6_   .��6k   .��5M      �� $
 Voie�6   $ PropertyChanged=�6*    5N        5O      5Q       =� ErrorTemplate 5R      �� 5S      .R�5T      �� .+�5V   "   ��  ��Name$ textBox��6<   �� 5W   "   
���  ����6,   �� *[0].ErrorContent+6N   5X      5Y      .��5Z   0   5[      �� 5\      $��1��6   $��_Ville :��6%   $��3q�5]      $	��Top=�6   
������ 5\   8   �� $ txtVille��$	 OneWay=�5]   )   �� 5^      -   5        $
 txtVille��5^      $��1��6    $��1��60   $
��Left=�6=   $
��10 3q�6X   $
 Wrap=�5_      $	��Top=�6   #���  62   $	��100��6_   �� 5`      $��2��6   $��_Code Postal :��6   $��3q�5a      $	��Top=�6   
������ 5`   2   �� $ txtCodePostal��$	 OneWay=�5a   )   �� 5b      -   5        $
 txtCodePostal��5b      $��1��6%   $��2��65   $
��Left=�6B   $
��10 3q�6]   $
 Wrap=�5c      $	��Top=�6   #���  62   $	��100��6_   5d      5e      5f      5g      