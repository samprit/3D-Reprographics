3D Reprographics
================

Tools used:

Kinect Fusion <br/> Microsoft 

MeshLab <br/> Visual Computing Lab - ISTI - CNR <br/> http://meshlab.sourceforge.net/

Slic3r <br/> Alessandro Ranellucci <br/> http://slic3r.org/


### What language is it written in?

Microsoft Visual C# has been used for the Kinect Fusion part.


### Main Features

Integrated the process of taking a 3D model of an object from Kinect and converting it into a 3D printable format into a single software.

Key features are:

  * Scan object using the Kinect Fusion library
  * Crop the object to get the desired shape
  * Filtering and repairing using MeshLab
  * Orienting the object and setting the size of the object using Slic3r for final printable form.
  * Converting 3D models into G-code instructions for 3D printers using Slic3r

### How to install?

You can just download the precompiled package; it will run without the need for any dependency.

### Instructions to use

There are three steps involved from taking the 3D scan of the image to converting it into a 3D printable format namely a .stl file.

- **Step 1:** Clicking on the *start* button present in the main starting window will open the Kinect Fusion software needed for taking the 3D scan of the object. <br/> *Kinect Fusion :* The first control option present is *Actions*. In *Create Mesh* option, one can save the 3D scan as a .stl, .obj or .ply file. Since the 3D printer present uses only the .stl file, we will use only that option. Then there is an option to reset the reconstruction to begin a completely new scan. <br/> In the *Image Options* one can select the appropriate check box to *capture color*, *pause integartion*, activate *near mode*, etc. The *Depth Threshold* option is to select the maximum and minimum depth to be captured. <br/> The *Maximum Integration weight* slider controls the temporal averaging of data into the reconstruction volume – increasing makes the system a higher detailed reconstruction, but one which takes longer to average. Decreasing it makes the volume respond faster to change in the depth (e.g. objects moving), but is noisier overall. <br/> The *Voxels Volume* settings enables one to change the size and shape of the reconstruction volume. For Saving the 3D scan by clicking on the Create Mesh button will cause the step 1 to complete.
- **Step 2:** This will open the .stl file in MeshLab for cropping the 3D object, rotating and smoothing and filtering it. For cropping the image select the option *select faces in a rectangular region* and then draw a rectangle over the region to delete. After selecting the face, pressing the delete button will delete the selected region. For rotating the object go to Filters->Normal, Curvatures and Orientation-> Transform rotate. Save the object by pressing Ctrl+E. After the application is closed, filtering techniques are applied to the object and a new file is created as "original file name"_output.stl. Use this file for all future references.
- **Step 3:** This will open the slic3r software needed for final setting the orientation of the object and also the size of the object. For importing the object click on *Add* button and go to the desired location where the .stl file is located.
