using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Kitware.VTK
{
	[ClassInterface(ClassInterfaceType.AutoDual), ComVisible(true)]
	public class RenderWindowControl : UserControl
	{
		private vtkRenderer m_Renderer;

		private vtkRenderWindow m_RenderWindow;

		private vtkRenderWindowInteractor m_RenderWindowInteractor;

		private string m_TestText;

		private bool m_AddTestActors = false;

		private bool m_AddedTestActors = false;

		private IContainer components = null;

		private IntPtr XDisplay;

		private bool AttachedInteractor;

		public vtkRenderWindow RenderWindow
		{
			get
			{
				return this.m_RenderWindow;
			}
		}

		public string TestText
		{
			get
			{
				return this.m_TestText;
			}
			set
			{
				this.m_TestText = value;
			}
		}

		public bool AddTestActors
		{
			get
			{
				return this.m_AddTestActors;
			}
			set
			{
				this.m_AddTestActors = value;
			}
		}

		public RenderWindowControl()
		{
			this.InitializeComponent();
		}

		private void TestAddActorsToRenderWindow(vtkRenderWindow renWin)
		{
			vtkConeSource vtkConeSource = new vtkConeSource();
			vtkMapper vtkMapper = vtkPolyDataMapper.New();
			vtkMapper.SetInputConnection(vtkConeSource.GetOutputPort());
			vtkActor vtkActor = new vtkActor();
			vtkActor.SetMapper(vtkMapper);
			vtkRenderer firstRenderer = renWin.GetRenderers().GetFirstRenderer();
			firstRenderer.AddActor(vtkActor);
			vtkTextActor vtkTextActor = new vtkTextActor();
			vtkTextActor.SetInput(vtkVersion.GetVTKSourceVersion());
			firstRenderer.AddActor(vtkTextActor);
		}

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					if (this.components != null)
					{
						this.components.Dispose();
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		internal void SyncRenderWindowSize()
		{
			if (this.m_RenderWindow != null)
			{
				this.m_RenderWindow.SetSize(base.Size.Width, base.Size.Height);
			}
		}

		private IntPtr GetXDisplay()
		{
			Type type = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
			if (type != null)
			{
				IntPtr xDisplay = (IntPtr)type.GetField("DisplayHandle", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
				this.XDisplay = xDisplay;
			}
			return this.XDisplay;
		}

		private void AttachInteractor()
		{
			if (!this.AttachedInteractor)
			{
				this.AttachedInteractor = true;
				this.m_RenderWindow.SetInteractor(this.m_RenderWindowInteractor);
			}
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			if (!base.DesignMode)
			{
				vtkLogoWidget vtkLogoWidget = new vtkLogoWidget();
				this.m_Renderer = vtkRenderer.New();
				this.m_RenderWindow = vtkRenderWindow.New();
				IntPtr xDisplay = this.GetXDisplay();
				bool flag = false;
				if (IntPtr.Zero != xDisplay)
				{
					flag = true;
				}
				if (flag)
				{
					this.m_RenderWindowInteractor = vtkGenericRenderWindowInteractor.New();
					this.m_RenderWindow.SetDisplayId(xDisplay);
				}
				else
				{
					this.m_RenderWindowInteractor = vtkRenderWindowInteractor.New();
				}
				vtkInteractorStyleSwitch vtkInteractorStyleSwitch = this.m_RenderWindowInteractor.GetInteractorStyle() as vtkInteractorStyleSwitch;
				if (null != vtkInteractorStyleSwitch)
				{
					vtkInteractorStyleSwitch.SetCurrentStyleToTrackballCamera();
				}
				this.m_RenderWindow.SetParentId(base.Handle);
				this.m_RenderWindow.AddRenderer(this.m_Renderer);
				if (!flag)
				{
					this.AttachInteractor();
				}
				vtkLogoWidget.Dispose();
			}
			base.OnHandleCreated(e);
		}

		protected override void OnHandleDestroyed(EventArgs e)
		{
			if (this.m_Renderer != null)
			{
				this.m_Renderer.SetRenderWindow(null);
			}
			if (this.m_RenderWindowInteractor != null)
			{
				this.m_RenderWindowInteractor.Dispose();
				this.m_RenderWindowInteractor = null;
			}
			if (this.m_RenderWindow != null)
			{
				this.m_RenderWindow.Dispose();
				this.m_RenderWindow = null;
			}
			if (this.m_Renderer != null)
			{
				this.m_Renderer.Dispose();
				this.m_Renderer = null;
			}
			base.OnHandleDestroyed(e);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetEventInformationFlipY(e.X, e.Y, 0, 0, 0, e.Clicks, null);
				MouseButtons button = e.Button;
				if (button != MouseButtons.Left)
				{
					if (button != MouseButtons.Right)
					{
						if (button == MouseButtons.Middle)
						{
							vtkGenericRenderWindowInteractor.MiddleButtonPressEvent();
						}
					}
					else
					{
						vtkGenericRenderWindowInteractor.RightButtonPressEvent();
					}
				}
				else
				{
					vtkGenericRenderWindowInteractor.LeftButtonPressEvent();
				}
			}
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetEventInformationFlipY(e.X, e.Y, 0, 0, 0, e.Clicks, null);
				vtkGenericRenderWindowInteractor.MouseMoveEvent();
			}
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetEventInformationFlipY(e.X, e.Y, 0, 0, 0, e.Clicks, null);
				MouseButtons button = e.Button;
				if (button != MouseButtons.Left)
				{
					if (button != MouseButtons.Right)
					{
						if (button == MouseButtons.Middle)
						{
							vtkGenericRenderWindowInteractor.MiddleButtonReleaseEvent();
						}
					}
					else
					{
						vtkGenericRenderWindowInteractor.RightButtonReleaseEvent();
					}
				}
				else
				{
					vtkGenericRenderWindowInteractor.LeftButtonReleaseEvent();
				}
			}
		}

		protected override void OnMouseWheel(MouseEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetEventInformationFlipY(e.X, e.Y, 0, 0, 0, e.Clicks, null);
				if (e.Delta > 0)
				{
					vtkGenericRenderWindowInteractor.MouseWheelForwardEvent();
				}
				else
				{
					vtkGenericRenderWindowInteractor.MouseWheelBackwardEvent();
				}
			}
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetKeyEventInformation(e.Control ? (byte)1 : (byte)0, e.Shift ? (byte)1 : (byte)0, (sbyte)e.KeyCode, 1, null);
				vtkGenericRenderWindowInteractor.KeyPressEvent();
			}
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetKeyEventInformation(0, 0, (sbyte)e.KeyChar, 1, e.KeyChar.ToString());
				vtkGenericRenderWindowInteractor.CharEvent();
			}
		}

		protected override void OnKeyUp(KeyEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetKeyEventInformation(e.Control ? (byte)1 : (byte)0, e.Shift ? (byte)1 : (byte)0, (sbyte)e.KeyCode, 1, null);
				vtkGenericRenderWindowInteractor.KeyReleaseEvent();
			}
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			this.SyncRenderWindowSize();
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.ConfigureEvent();
			}
			base.OnSizeChanged(e);
			base.Invalidate();
		}

		[DllImport("user32.dll")]
		internal static extern IntPtr SetFocus(IntPtr hWnd);

		protected override void OnGotFocus(EventArgs e)
		{
			if (this.m_RenderWindow != null)
			{
				IntPtr genericWindowId = this.m_RenderWindow.GetGenericWindowId();
				if (IntPtr.Zero != genericWindowId)
				{
					try
					{
						RenderWindowControl.SetFocus(genericWindowId);
					}
					catch
					{
					}
				}
			}
			base.OnGotFocus(e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			if (this.m_RenderWindow != null)
			{
				if (base.Visible)
				{
					this.SyncRenderWindowSize();
					if (this.m_RenderWindow.GetInteractor() != this.m_RenderWindowInteractor)
					{
						this.AttachInteractor();
						this.m_RenderWindow.Render();
					}
					if (this.AddTestActors && !this.m_AddedTestActors)
					{
						this.m_AddedTestActors = true;
						this.TestAddActorsToRenderWindow(this.m_RenderWindow);
					}
					this.m_RenderWindow.Render();
				}
			}
			base.OnPaint(e);
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
		}

		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "RenderWindowControl";
			base.Size = new Size(400, 300);
			base.ResumeLayout(false);
		}
	}
}
