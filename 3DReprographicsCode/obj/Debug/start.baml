   M S B A M L   `   `   `  ����  KinectFusionExplorer-WPF9    3Microsoft.Samples.Kinect.KinectFusionExplorer.start   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  3D Reprographics��5   	   $	��640��5   	   $	��980��6    � 	Resources 5         MediumGreyBrush �� Color  DarkGreyBrush  KinectPurpleBrush  KinectBlueBrush �� 
TargetType �� Property �� Value  StartButton �� 
TargetType �� Orientation ��Name	 �� TextAlignment
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 !     &	 B     &	 c     '�� �     &	 �     7  7  �� 5	   
   $ #6e6e6e��62   �� 5
   
   $ #505050��60   �� 5   
   $ #52318F��64   �� 5   
   $ #00BCF2��62   �� 5   
   " ��6   .�5      ��  �@J�SnapsToDevicePixels . 64   5      �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $ 
Horizontal=�6)   
������ .+�5   "   �� $ StartButtonText��6,   #��z��6E   $
	 Left=�6f   $��Center=�6|   8��  $��36(�6�   $��Light"�6�   � 5   "   $��9 0 0 0q�6'   .+�5   &   �� $
 StartButtonNormal��6,   $��Images/StartNormal.png��6G   $
��None=�6g   $��Center=�6v   �� 5   &   $
 StartButtonHover��6,   $��Images/StartHover.png��6F   $
��None=�6e   $��Center=�6t   $y�	Collapsed=�6�   5   #   5      5       5      P� 5        �@J�IsMouseOver . . �5!   "   �� $ StartButtonNormal��6Q    � y�$ 	Collapsed=�6?   6Q   �� 5"   "   $ StartButtonHover��6O    � y�$ Visible=�6?   6O   �� 5#   "   8  $ StartButtonText��6j    � ��5$      5&      5(      5)      5*      .��5,      � -   5         �Name$ 
layoutGrid��5,      $��
10 0 10 10q�6    � RowDefinitions 5-   
   �� 5.      $
��Auto �6   �� 5/      $��* �6   .+�51   
   ]� $��0��6   $��108.388��6!   $	��Top=�62   $��2��6J   .+�52      �� $
��Left=�6   $��Images\Logo.png��6*   $
��None=�6C   $��0 10 0 5q�6S   �� 53      -   5        $��NoRulesText��53   �   $��Right=�6   $��2��6/   $��Right=�6?   $��Bottom=�6[   #��[  6v   $��Segoe UI)�6�   $��18(�6�   $y�	Collapsed=�6�   $��10 0 0 0q�6�   
(No Rules)6  �� 54      $��Right=�6   $��0,25.806,-1,42.224q�6/   $��2��6L   $��Right=�6\   $��Center=�6x   #��[  6�   $��Segoe UI)�6�   $��26.667(�6�   $��40.358��6�   $��229.973��6�   $
��Bold"�6	  3D Reprographics6-  55      � 56   
   -   5        $��WelcomePanel��56   1   $��1��6   $y�Visible=�6   $��
50,0,50,50q�6E   $	��393��6Y   $��Bottom=�6f    � ColumnDefinitions 57      �� 58      $��3* �6#   �� 59      $��2* �6#    5;      �� 5<      $��3* �6    �� 5=      $��* �6    .+�5?      �� $��0��6   $��2��6)   .+�5@      �� #��[ 6   $��48(�6L   $��Segoe UI)�6Z   $��Light"�6p   $��0 0 0 10q�6�   	Welcome5B      �� 5C      #��[  6   $��18(�6J   $��Segoe UI)�6X   $��Regular"�6n   /-MoodGraph is a Face Tracking Kinect App which�� 5D   ?   )'is designed to show user's Mood varying�� 5E   :   over a period of time.�� 5F   (   20Users as well as Developers can analyse the data�� 5G   B   +)to know the area of interest of the user.�� 5H   ;   �� 5I      ;9After pressing the start button the user will be directed�� 5J   K   =;to an application of user's interest based on past results.�� 5K   N   53Press the start button to start tracking your mood.5M      5N      �� 5O      -   5        $��Start��5O   �   $��1��6   $��1��6%   #��[ 62   $��Start��6W   $
��Auto��6g   $��Center=�6u   $��Bottom=�6�   $��10q�6�    � Cursor$
 Hand��6�   �� 5P      $��1��6   $��Images/rex.png��6$   $
��Left=�6<   $	��212��6W   $��	29,52,0,0q�6d   $	��Top=�6w   $	��266��6�   5Q      5S      5T      