   M S B A M L   `   `   `  ����   3DReprographics<    6Microsoft.Samples.Kinect.KinectFusionExplorer.nextStep   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  nextStep��$	��468��$��749.5�� � 	Resources    MediumGreyBrush �� Color  DarkGreyBrush  KinectPurpleBrush  KinectBlueBrush  KinectGreenBrush  KinectRedBrush �� 
TargetType  Step1Button �� Property �� Value �� 
TargetType �� Orientation ��Name	 �� TextAlignment
 ��Name  Step2Button �� Triggers P� Property P� Value �� 
TargetName��%  &	        &	      &	 &     &	 9     &	 L     &	 _     &	 r     7  &	 �    7  7  �� $ #6e6e6e���� $ #505050���� $ #52318F���� $ #00BCF2���� $ #339933���� $ #980000���� " ��.���  � �� �� " ��.R�� .+��� $ 
Horizontal=�
������ .+��� $ StartButtonText��#��z��$	 Center=�$��Center=�8��  $��36(�$��Light"�� $��9 0 0 0q�.+��� $
 StartButtonNormal��$��Images\StartGreen.png��$
��None=�$��Center=��� " ��.���  � �� �� " ��.R�� .+��� $ 
Horizontal=�
������ .+��� $ StartButtonText��#��z��$
	 Left=�$��Center=�8��  $��36(�$��Light"�� $��9 0 0 0q�.+��� $
 StartButtonNormal��$��Images\StartNormal.png��$
��None=�$��Center=��� $
 StartButtonHover��$��Images\StartHover.png��$
��None=�$��Center=�$y�	Collapsed=� P�  �@J�IsMouseOver . . ��� $ StartButtonNormal�� � y�$ 	Collapsed=��� $ StartButtonHover�� � y�$ Visible=��� 8  $ StartButtonText�� � ��.���  � ColumnDefinitions �� $	��43* ��� $	��14* �.+��� -    ��Name$ Step1��#���  $��STEP1:��$
��Auto��$��51.877,142,341.623,199q�$��9(� J� RenderTransformOrigin$ 0.564,-0.083&� � Cursor$
 Hand���� -   $ Step2��#��[ $��STEP2:��$
��Auto��$��0,142,111.5,199q�$��9(�$ 0.564,-0.083&�$
 Hand��$��Right=�$	��165���� -   $ Step3��#��[ $��STEP3:��$
��Auto��$��Right=�$��0,142,50,199q�$	��165��$��9(�$ 0.564,-0.083&�$
 Hand��$��2���� -   $ 	ViewModel��#��[ $��
View Model��$
��Auto��$��Right=�$��0,308.5,97.5,32.5q�$	��181��$��9(�$ 0.564,-0.083&�$
 Hand���� $��5q�$��10q� �� CornerRadius$ 5�����	#FF00BCF2$��2��._��� $��0,5,36,0q�$��Images/Kinect.ico��$
��Fill=�$��Right=�$	��105��$
��99.5��$	��Top=��� $��Images/Logo.png��$
��None=�$��37,49.5,0,0q�$��74��$	��Top=�$
��Left=�$��180.754���� $��Segoe UI)�$��16(�#��[  $
��65.5��$��51.877,238,328.5,133.5q�$��Center=��� $�Scanning the object ���� �� $ �with Kinect and saving it ���� �� $�as a .stl file���� $��Segoe UI)�$��16(�#��[  $
��65.5��$��Right=�$��0,238,97.5,133.5q�$��Center=�$	��179���� $�Cropping and rotating���� �� $�the 3D object obtained���� �� $�and smoothing���� �� $�and filtering the object���� $��Segoe UI)�$��16(�#��[  $
��65.5��$��Right=�$��0,238,36,133.5q�$��Center=�$	��179��$��2���� $�Setting the final���� �� $�orientation and the scale���� �� $�of the object��