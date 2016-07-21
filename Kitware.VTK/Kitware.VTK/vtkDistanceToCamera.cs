using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDistanceToCamera : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceToCamera";

		public new static readonly string MRClassNameKey;

		static vtkDistanceToCamera()
		{
			vtkDistanceToCamera.MRClassNameKey = "class vtkDistanceToCamera";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistanceToCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceToCamera"));
		}

		public vtkDistanceToCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceToCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistanceToCamera New()
		{
			vtkDistanceToCamera result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceToCamera.vtkDistanceToCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceToCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDistanceToCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDistanceToCamera.vtkDistanceToCamera_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkDistanceToCamera_GetMTime_01(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkDistanceToCamera.vtkDistanceToCamera_GetMTime_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceToCamera_GetRenderer_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceToCamera.vtkDistanceToCamera_GetRenderer_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkDistanceToCamera_GetScaling_03(HandleRef pThis);

		public virtual bool GetScaling()
		{
			return vtkDistanceToCamera.vtkDistanceToCamera_GetScaling_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkDistanceToCamera_GetScreenSize_04(HandleRef pThis);

		public virtual double GetScreenSize()
		{
			return vtkDistanceToCamera.vtkDistanceToCamera_GetScreenSize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDistanceToCamera_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDistanceToCamera.vtkDistanceToCamera_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDistanceToCamera_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDistanceToCamera.vtkDistanceToCamera_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceToCamera_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDistanceToCamera NewInstance()
		{
			vtkDistanceToCamera result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceToCamera.vtkDistanceToCamera_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceToCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceToCamera_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistanceToCamera SafeDownCast(vtkObjectBase o)
		{
			vtkDistanceToCamera vtkDistanceToCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceToCamera.vtkDistanceToCamera_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistanceToCamera = (vtkDistanceToCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistanceToCamera.Register(null);
				}
			}
			return vtkDistanceToCamera;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDistanceToCamera_ScalingOff_10(HandleRef pThis);

		public virtual void ScalingOff()
		{
			vtkDistanceToCamera.vtkDistanceToCamera_ScalingOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDistanceToCamera_ScalingOn_11(HandleRef pThis);

		public virtual void ScalingOn()
		{
			vtkDistanceToCamera.vtkDistanceToCamera_ScalingOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDistanceToCamera_SetRenderer_12(HandleRef pThis, HandleRef ren);

		public void SetRenderer(vtkRenderer ren)
		{
			vtkDistanceToCamera.vtkDistanceToCamera_SetRenderer_12(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDistanceToCamera_SetScaling_13(HandleRef pThis, byte _arg);

		public virtual void SetScaling(bool _arg)
		{
			vtkDistanceToCamera.vtkDistanceToCamera_SetScaling_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDistanceToCamera_SetScreenSize_14(HandleRef pThis, double _arg);

		public virtual void SetScreenSize(double _arg)
		{
			vtkDistanceToCamera.vtkDistanceToCamera_SetScreenSize_14(base.GetCppThis(), _arg);
		}
	}
}
