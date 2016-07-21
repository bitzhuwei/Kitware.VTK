using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFocalPlanePointPlacer : vtkPointPlacer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFocalPlanePointPlacer";

		public new static readonly string MRClassNameKey;

		static vtkFocalPlanePointPlacer()
		{
			vtkFocalPlanePointPlacer.MRClassNameKey = "class vtkFocalPlanePointPlacer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFocalPlanePointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFocalPlanePointPlacer"));
		}

		public vtkFocalPlanePointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkFocalPlanePointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFocalPlanePointPlacer New()
		{
			vtkFocalPlanePointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFocalPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFocalPlanePointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlanePointPlacer_ComputeWorldPosition_01(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_ComputeWorldPosition_01(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlanePointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkFocalPlanePointPlacer_GetOffset_03(HandleRef pThis);

		public virtual double GetOffset()
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_GetOffset_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkFocalPlanePointPlacer_GetPointBounds_04(HandleRef pThis);

		public virtual double[] GetPointBounds()
		{
			IntPtr intPtr = vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_GetPointBounds_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkFocalPlanePointPlacer_GetPointBounds_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		public virtual void GetPointBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_GetPointBounds_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkFocalPlanePointPlacer_GetPointBounds_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetPointBounds(IntPtr _arg)
		{
			vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_GetPointBounds_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlanePointPlacer_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlanePointPlacer_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkFocalPlanePointPlacer_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFocalPlanePointPlacer NewInstance()
		{
			vtkFocalPlanePointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFocalPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkFocalPlanePointPlacer_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFocalPlanePointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkFocalPlanePointPlacer vtkFocalPlanePointPlacer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFocalPlanePointPlacer = (vtkFocalPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFocalPlanePointPlacer.Register(null);
				}
			}
			return vtkFocalPlanePointPlacer;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkFocalPlanePointPlacer_SetOffset_12(HandleRef pThis, double _arg);

		public virtual void SetOffset(double _arg)
		{
			vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_SetOffset_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkFocalPlanePointPlacer_SetPointBounds_13(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetPointBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_SetPointBounds_13(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkFocalPlanePointPlacer_SetPointBounds_14(HandleRef pThis, IntPtr _arg);

		public virtual void SetPointBounds(IntPtr _arg)
		{
			vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_SetPointBounds_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlanePointPlacer_ValidateWorldPosition_15(HandleRef pThis, IntPtr worldPos);

		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_ValidateWorldPosition_15(base.GetCppThis(), worldPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkFocalPlanePointPlacer_ValidateWorldPosition_16(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkFocalPlanePointPlacer.vtkFocalPlanePointPlacer_ValidateWorldPosition_16(base.GetCppThis(), worldPos, worldOrient);
		}
	}
}
