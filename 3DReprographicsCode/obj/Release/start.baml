   M S B A M L   `   `   `  ����   3DReprographics9    3Microsoft.Samples.Kinect.KinectFusionExplorer.start   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  3D Reprographics��$	��640��$	��980�� � 	Resources    MediumGreyBrush �� Color  DarkGreyBrush  KinectPurpleBrush  KinectBlueBrush �� 
TargetType �� Property �� Value  StartButton �� 
TargetType �� Orientation ��Name	 �� TextAlignment
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	      &	 &     &	 9     '�� L     &	 �     7  7  �� $ #6e6e6e���� $ #505050���� $ #52318F���� $ #00BCF2���� " ��.���  �@J�SnapsToDevicePixels . �� " ��.���  � �� �� " ��.R�� .+��� $ 
Horizontal=�
������ .+��� $ StartButtonText��#��z��$
	 Left=�$��Center=�8��  $��36(�$��Light"�� $��9 0 0 0q�.+��� $
 StartButtonNormal��$��Images/StartNormal.png��$
��None=�$��Center=��� $
 StartButtonHover��$��Images/StartHover.png��$
��None=�$��Center=�$y�	Collapsed=� P�  �@J�IsMouseOver . . ��� $ StartButtonNormal�� � y�$ 	Collapsed=��� $ StartButtonHover�� � y�$ Visible=��� 8  $ StartButtonText�� � ��.��� -    �Name$ 
layoutGrid��$��
10 0 10 10q� � RowDefinitions �� $
��Auto ��� $��* �.+�]� $��0��$��108.388��$	��Top=�$��2��.+��� $
��Left=�$��Images\Logo.png��$
��None=�$��0 10 0 5q��� -   $��NoRulesText��$��Right=�$��2��$��Right=�$��Bottom=�#��[  $��Segoe UI)�$��18(�$y�	Collapsed=�$��10 0 0 0q�
(No Rules)�� $��Right=�$��0,25.806,-1,42.224q�$��2��$��Right=�$��Center=�#��[  $��Segoe UI)�$��26.667(�$��40.358��$��229.973��$
��Bold"�3D Reprographics� -   $��WelcomePanel��$��1��$y�Visible=�$��
50,0,50,50q�$	��393��$��Bottom=� � ColumnDefinitions �� $��3* ��� $��2* � �� $��3* ��� $��* �.+��� $��0��$��2��.+��� #��[ $��48(�$��Segoe UI)�$��Light"�$��0 0 0 10q�	Welcome�� #��[  $��18(�$��Segoe UI)�$��Regular"�$
��Wrap=�$	 Justify=��� $]�W3D Reprographics is scanning of an object and converting it into a 3D printable format.���� �� �� �� $���This software integrates the three softwares Kinect Fusion MeshLab and slic3r to make the process of taking the 3D scan of object and converting it into a 3D printable format easier. Kinect Fusion is used to take the 3D scan. MeshLab is used for editing the 3D model and slic3r generates the final G-code for 3D printing.���� �� �� �� $C�=Click the start button to begin taking 3D scan of the object.���� �� �� -   $��Start��$��1��$��1��#��[ $��Start��$
��Auto��$��Center=�$��Bottom=�$��10q� � Cursor$
 Hand���� $��1��$��Images/rex.png��$
��Left=�$	��212��$��	29,52,0,0q�$	��Top=�$	��266��