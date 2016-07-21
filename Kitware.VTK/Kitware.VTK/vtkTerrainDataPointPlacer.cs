using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTerrainDataPointPlacer : vtkPointPlacer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTerrainDataPointPlacer";

		public new static readonly string MRClassNameKey;

		static vtkTerrainDataPointPlacer()
		{
			vtkTerrainDataPointPlacer.MRClassNameKey = "class vtkTerrainDataPointPlacer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTerrainDataPointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTerrainDataPointPlacer"));
		}

		public vtkTerrainDataPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTerrainDataPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTerrainDataPointPlacer New()
		{
			vtkTerrainDataPointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTerrainDataPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTerrainDataPointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTerrainDataPointPlacer_AddProp_01(HandleRef pThis, HandleRef arg0);

		public virtual void AddProp(vtkProp arg0)
		{
			vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_AddProp_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTerrainDataPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTerrainDataPointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_ComputeWorldPosition_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkTerrainDataPointPlacer_GetHeightOffset_04(HandleRef pThis);

		public virtual double GetHeightOffset()
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_GetHeightOffset_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTerrainDataPointPlacer_GetPropPicker_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPropPicker GetPropPicker()
		{
			vtkPropPicker vtkPropPicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_GetPropPicker_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkTerrainDataPointPlacer_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTerrainDataPointPlacer_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTerrainDataPointPlacer_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTerrainDataPointPlacer NewInstance()
		{
			vtkTerrainDataPointPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTerrainDataPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTerrainDataPointPlacer_RemoveAllProps_10(HandleRef pThis);

		public virtual void RemoveAllProps()
		{
			vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_RemoveAllProps_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTerrainDataPointPlacer_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTerrainDataPointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkTerrainDataPointPlacer vtkTerrainDataPointPlacer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTerrainDataPointPlacer = (vtkTerrainDataPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTerrainDataPointPlacer.Register(null);
				}
			}
			return vtkTerrainDataPointPlacer;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTerrainDataPointPlacer_SetHeightOffset_12(HandleRef pThis, double _arg);

		public virtual void SetHeightOffset(double _arg)
		{
			vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_SetHeightOffset_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTerrainDataPointPlacer_ValidateDisplayPosition_13(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

		public override int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_ValidateDisplayPosition_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), displayPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTerrainDataPointPlacer_ValidateWorldPosition_14(HandleRef pThis, IntPtr worldPos);

		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_ValidateWorldPosition_14(base.GetCppThis(), worldPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTerrainDataPointPlacer_ValidateWorldPosition_15(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkTerrainDataPointPlacer.vtkTerrainDataPointPlacer_ValidateWorldPosition_15(base.GetCppThis(), worldPos, worldOrient);
		}
	}
}
