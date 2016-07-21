using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPointPlacer : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointPlacer";

		public new static readonly string MRClassNameKey;

		static vtkPointPlacer()
		{
			vtkPointPlacer.MRClassNameKey = "class vtkPointPlacer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointPlacer"));
		}

		public vtkPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointPlacer New()
		{
			vtkPointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointPlacer.vtkPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPointPlacer.vtkPointPlacer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointPlacer_ComputeWorldPosition_01(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		public virtual int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPointPlacer.vtkPointPlacer_ComputeWorldPosition_01(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		public virtual int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPointPlacer.vtkPointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointPlacer_GetPixelTolerance_03(HandleRef pThis);

		public virtual int GetPixelTolerance()
		{
			return vtkPointPlacer.vtkPointPlacer_GetPixelTolerance_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointPlacer_GetPixelToleranceMaxValue_04(HandleRef pThis);

		public virtual int GetPixelToleranceMaxValue()
		{
			return vtkPointPlacer.vtkPointPlacer_GetPixelToleranceMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointPlacer_GetPixelToleranceMinValue_05(HandleRef pThis);

		public virtual int GetPixelToleranceMinValue()
		{
			return vtkPointPlacer.vtkPointPlacer_GetPixelToleranceMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkPointPlacer_GetWorldTolerance_06(HandleRef pThis);

		public virtual double GetWorldTolerance()
		{
			return vtkPointPlacer.vtkPointPlacer_GetWorldTolerance_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkPointPlacer_GetWorldToleranceMaxValue_07(HandleRef pThis);

		public virtual double GetWorldToleranceMaxValue()
		{
			return vtkPointPlacer.vtkPointPlacer_GetWorldToleranceMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkPointPlacer_GetWorldToleranceMinValue_08(HandleRef pThis);

		public virtual double GetWorldToleranceMinValue()
		{
			return vtkPointPlacer.vtkPointPlacer_GetWorldToleranceMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointPlacer_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPointPlacer.vtkPointPlacer_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointPlacer_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPointPlacer.vtkPointPlacer_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointPlacer_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPointPlacer NewInstance()
		{
			vtkPointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointPlacer.vtkPointPlacer_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointPlacer_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkPointPlacer vtkPointPlacer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointPlacer.vtkPointPlacer_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointPlacer = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointPlacer.Register(null);
				}
			}
			return vtkPointPlacer;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointPlacer_SetPixelTolerance_14(HandleRef pThis, int _arg);

		public virtual void SetPixelTolerance(int _arg)
		{
			vtkPointPlacer.vtkPointPlacer_SetPixelTolerance_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointPlacer_SetWorldTolerance_15(HandleRef pThis, double _arg);

		public virtual void SetWorldTolerance(double _arg)
		{
			vtkPointPlacer.vtkPointPlacer_SetWorldTolerance_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointPlacer_UpdateInternalState_16(HandleRef pThis);

		public virtual int UpdateInternalState()
		{
			return vtkPointPlacer.vtkPointPlacer_UpdateInternalState_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointPlacer_UpdateWorldPosition_17(HandleRef pThis, HandleRef ren, IntPtr worldPos, IntPtr worldOrient);

		public virtual int UpdateWorldPosition(vtkRenderer ren, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPointPlacer.vtkPointPlacer_UpdateWorldPosition_17(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointPlacer_ValidateDisplayPosition_18(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

		public virtual int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
		{
			return vtkPointPlacer.vtkPointPlacer_ValidateDisplayPosition_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), displayPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointPlacer_ValidateWorldPosition_19(HandleRef pThis, IntPtr worldPos);

		public virtual int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkPointPlacer.vtkPointPlacer_ValidateWorldPosition_19(base.GetCppThis(), worldPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointPlacer_ValidateWorldPosition_20(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		public virtual int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPointPlacer.vtkPointPlacer_ValidateWorldPosition_20(base.GetCppThis(), worldPos, worldOrient);
		}
	}
}
