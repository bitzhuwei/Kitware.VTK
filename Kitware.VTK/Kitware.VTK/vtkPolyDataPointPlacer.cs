using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyDataPointPlacer : vtkPointPlacer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataPointPlacer";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataPointPlacer()
		{
			vtkPolyDataPointPlacer.MRClassNameKey = "class vtkPolyDataPointPlacer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataPointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataPointPlacer"));
		}

		public vtkPolyDataPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataPointPlacer New()
		{
			vtkPolyDataPointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyDataPointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointPlacer_AddProp_01(HandleRef pThis, HandleRef arg0);

		public virtual void AddProp(vtkProp arg0)
		{
			vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_AddProp_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_ComputeWorldPosition_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointPlacer_GetNumberOfProps_04(HandleRef pThis);

		public int GetNumberOfProps()
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_GetNumberOfProps_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataPointPlacer_GetPropPicker_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPropPicker GetPropPicker()
		{
			vtkPropPicker vtkPropPicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_GetPropPicker_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropPicker = (vtkPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropPicker.Register(null);
				}
			}
			return vtkPropPicker;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointPlacer_HasProp_06(HandleRef pThis, HandleRef arg0);

		public int HasProp(vtkProp arg0)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_HasProp_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointPlacer_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointPlacer_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataPointPlacer_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataPointPlacer NewInstance()
		{
			vtkPolyDataPointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointPlacer_RemoveAllProps_11(HandleRef pThis);

		public virtual void RemoveAllProps()
		{
			vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_RemoveAllProps_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointPlacer_RemoveViewProp_12(HandleRef pThis, HandleRef prop);

		public virtual void RemoveViewProp(vtkProp prop)
		{
			vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_RemoveViewProp_12(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataPointPlacer_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataPointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataPointPlacer vtkPolyDataPointPlacer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataPointPlacer = (vtkPolyDataPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataPointPlacer.Register(null);
				}
			}
			return vtkPolyDataPointPlacer;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointPlacer_ValidateDisplayPosition_14(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

		public override int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_ValidateDisplayPosition_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), displayPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointPlacer_ValidateWorldPosition_15(HandleRef pThis, IntPtr worldPos);

		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_ValidateWorldPosition_15(base.GetCppThis(), worldPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointPlacer_ValidateWorldPosition_16(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPolyDataPointPlacer.vtkPolyDataPointPlacer_ValidateWorldPosition_16(base.GetCppThis(), worldPos, worldOrient);
		}
	}
}
