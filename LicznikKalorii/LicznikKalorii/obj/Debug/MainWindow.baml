   M S B A M L   `   `   `  ����I  ELicznikKalorii, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LicznikKaloriiLicznikKalorii  5   	       LicznikKalorii.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:LicznikKalorii     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Licznik kalorii��5	   	   $	��550��6!   $	��900��6.   .��5
      � $��
0,0,-0.4,0q�6   ��5   
   �� 5       �� ImageSource$ background.png��6    j� Stretch$ UniformToFill=�66   .+�5   
   �� -   5        $
��prom��5      $��	title.png��6   $��Center=�6/   $��54��6L   $��	10,10,0,0q�6X   $	��Top=�6k   $	��395��6�    J� RenderTransformOrigin$ 0.505,0.686&�6�   �� 5   
   $#��Wprowadz poniższe parametry:��6   $
��Left=�67   $��350,141,0,0q�6R   $	��Top=�6g   �� 5   
   $��Płeć��6   $
��Left=�6   $��350,180,0,0q�6:   $	��Top=�6O   �� 5   
   -   5        $��ComboBoxPlec��5      $
��Left=�6'   $��440,185,0,0q�6B   $	��Top=�6W   $	��120��6o   $ 0.488,0.509&�6�   �� 5   
   $
��Wiek��6   $
��Left=�6   $��350,218,0,0q�6:   $	��Top=�6O   �� 5   
   -   5        $��textBoxWiek��5      $
��Left=�6%   $��23��6@   $��440,222,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   6�   �� 5   
   $��Wzrost��6   $
��Left=�6!   $��351,254,0,0q�6<   $	��Top=�6Q   �� 5   
   -   5        $��textBoxWzrost��5      $
��Left=�6'   $��23��6B   $��440,258,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   6�   �� 5   
   $
��Waga��6   $
��Left=�6   $��351,290,0,0q�6:   $	��Top=�6O   �� 5   
   -   5        $��textBoxWaga��5      $
��Left=�6%   $��23��6@   $��440,294,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   6�   �� 5   
   $��Aktywność fizyczna��6   $
��Left=�6-   $��287,327,0,0q�6H   $	��Top=�6]   $ 0.484,1.743&�6u   �� 5   
   -   5        $��ComboBoxAktywnosc��5      $
��Left=�6,   $��440,332,0,0q�6G   $	��Top=�6\   $	��255��6t   6�   �� 5    
   $	��Cel��6   $
��Left=�6   $��351,363,0,0q�69   $	��Top=�6N   �� 5!   
   -   5        $��ComboBoxCel��5!      $
��Left=�6&   $��440,368,0,0q�6A   $	��Top=�6V   $	��255��6n   6z   �� 5#   
   -   5        $��Dalej��5#      $��Dalej��6   $
��Left=�6I   $��758,441,0,0q�6d   $	��Top=�6y   $��75��6�   ���	#FFE8A86D6�   �� 5$   
   -	   5        $��	Powitanie��5$      $��Center=�6%   $��254,69,245,0q�6B   $
��Wrap=�6X   $	��Top=�6l   $	��395��6�   
���   �
������� J� Opacity$ 0Q�6�   5&      5'      