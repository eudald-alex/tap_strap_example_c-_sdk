   M S B A M L   `   `   `  ����C  ?test_tap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:test_taptest_tap  5   	       test_tap.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:test_tap     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��550��6)   ���#333333.��5	      � .+�5
   
   �  � ColumnDefinitions 5      �� 5      $	��150 �6#   �� 5      $	��150 �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $��50 �6    �� 5      $��* �6    �� 5      $��50 �6    �� 5      $��50 �6    .+�5      �� $��	Text Tap:��6   
�������$��0��6@   $��0��6P   $��Center=�6]   $��Center=�6z   �� 5      $��Mouse Values:��6   
�������$��1��6B   $��0��6R   $��Center=�6_   $��Center=�6|   �� 5      $��Vibrate thumb:��6   
�������$��0��6@   $��3��6P   $��Center=�6]   $��Center=�6z   �� 5      -   5         ��Name$ txb_tap��5      $��10,10,10,10q�6)   $��0��6>   $��1��6N   
�������$
��Wrap=�6r   �� 5      -   5        $ txb_air��5      $��10,10,10,10q�6)   $��1��6>   $��1��6N   
�������6[   � 5      $��2��6   $��0��6#    5       �� 5!      $��* �6$   �� 5"      $��* �6$   .+�5$      �� $��Raw Values:��6   
�������$��0��6D   $��0��6T   $��Center=�6a   $��Center=�6~   � 5%      $��1��6    5&      �� 5'      $��* �6+   �� 5(      $��* �6+   .+�5*      �� $��Thumb Values:��6   
�������$��0��6G   $��0��6W   $��Center=�6d   $��Center=�6�   �� 5+      $��Gyro Values:��6   
�������$��1��6G   $��0��6W   $��Center=�6d   $��Center=�6�   5,      5-      � 5/      -   5         �Name$ 
Raw_values��5/      $��2��6'   $��1��67    50      �� 51      $��* �6'   �� 52      $��* �6'    54      �� 55      $��* �6$   �� 56      $��* �6$   �� 57      $��* �6$   .+�59      �� -   5        $ txb_raw_tb_x��59      $��10,10,10,10q�62   $��0��6G   $��0��6W   
�������6d   �� 5:      -   5        $ txb_raw_tb_y��5:      $��10,10,10,10q�62   $��0��6G   $��1��6W   
�������6d   �� 5;      -   5        $ txb_raw_tb_z��5;      $��10,10,10,10q�62   $��0��6G   $��2��6W   
�������6d   �� 5<      -   5        $ txb_raw_gy_x��5<      $��10,10,10,10q�62   $��1��6G   $��0��6W   
�������6d   �� 5=      -   5        $ txb_raw_gy_y��5=      $��10,10,10,10q�62   $��1��6G   $��1��6W   
�������6d   �� 5>      -	   5        $ txb_raw_gy_z��5>      $��10,10,10,10q�62   $��1��6G   $��2��6W   
�������6d   5?      �� 5B      -
   5         ��Name$ btn_tap��5B      $	��TAP��6*   $��0��6<   $��2��6L   
�������$��Center=�6p   $��Center=�6�   $��50��5C      $��25��6    6,   �� 5D      -   5        $ 	btn_mouse��5D      $��MOUSE��6,   $��1��6>   $��2��6N   
�������$��Center=�6r   $��Center=�6�   $��50��5E      $��25��6    6,   �� 5F      -   5        $ btn_raw��5F      $	��RAW��6*   $��2��6<   $��2��6L   
�������$��Center=�6p   $��Center=�6�   $��50��5G      $��25��6    6,   �� 5H      -   5        $ btn_vibrate��5H      $��Vibrate��6*   $��1��6<   $��3��6L   
�������$��Center=�6p   $��Center=�6�   $��50��5I      $��25��6    6,   5K      5L      5M      