   M S B A M L   `   `   `  ����I  ELicznikKalorii, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LicznikKaloriiLicznikKalorii  5   	       LicznikKalorii.Kalkulator   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:LicznikKalorii     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
Kalkulator��5	   	   $	��550��6   $	��900��6)   $��Center=�65   $��Center=�6R   .��5
      � ��5   
   �� 5       �� ImageSource$ background.png��6    j� Stretch$ UniformToFill=�66   .+�5   
   �� -   5        $
��prom��5      $��	title.png��6   $��Center=�6/   $��54��6L   $��	10,10,0,0q�6X   $	��Top=�6k   $	��395��6�    J� RenderTransformOrigin$ 0.505,0.686&�6�   �� 5   
   $��Wybierz produkt z listy:��6   $
��Left=�63   $��137,110,0,0q�6N   $	��Top=�6c   $	��253��6{   �� 5   
   -   5        $��TabelaKaloryczna��5      $
��Left=�6+   $	��288��6F   $��137,151,0,0q�6S   $	��Top=�6h   $	��253��6�    �� View 5      �� 5      .P�5      �� 5      5      �� 5   
   $(��"Podaj ilość spożytego produktu:��6   $
��Left=�6:   $��508,110,0,0q�6U   $	��Top=�6j   $	��210��6�   �� 5   
   -   5        $��IloscProduktu��5      $
��Left=�6'   $��23��6B   $��508,151,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��177��6�   �� 5   
   $
��Left=�6   $��23��6-   $��681,151,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $��37��6z   $��gr��6�   $��14(�6�   ���	#FFFDFDFD���	#FF74B073 �� TextAlignment$ Center=�6�   �� 5   
   -   5        $��Oblicz��5      $
��Left=�6>   $��577,195,0,0q�6Y   $	��Top=�6n   $��75��6�   �� 5   
   -   5        $��
WynikLabel��5      $��Wynik:��6"   $
��Left=�63   $��508,285,0,0q�6N   $	��Top=�6c   $y�Hidden=�6{   �� 5   
   -   5        $��Wynik��5      $
��Left=�6!   $��508,329,0,0q�6<   $
��Wrap=�6Q   $	��Top=�6e   $��97��6}   $	��210��6�    J� IsHitTestVisible .  	 � Cursor$	  ��6�   
 �� TextAlignment$
 Center=�6�   �� 5   
   -   5        $
��Menu��5      $��Powrót��6   $
��Left=�6/   $��	24,24,0,0q�6J   $	��Top=�6]   $	��100��6u   $��23��6�   6�   5!      5"      