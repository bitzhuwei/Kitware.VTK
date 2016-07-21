using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractGeometry : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractGeometry";

		public new static readonly string MRClassNameKey;

		static vtkExtractGeometry()
		{
			vtkExtractGeometry.MRClassNameKey = "class vtkExtractGeometry";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractGeometry.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractGeometry"));
		}

		public vtkExtractGeometry(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractGeometry_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractGeometry New()
		{
			vtkExtractGeometry result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractGeometry.vtkExtractGeometry_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractGeometry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractGeometry() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractGeometry.vtkExtractGeometry_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGeometry_ExtractBoundaryCellsOff_01(HandleRef pThis);

		public virtual void ExtractBoundaryCellsOff()
		{
			vtkExtractGeometry.vtkExtractGeometry_ExtractBoundaryCellsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGeometry_ExtractBoundaryCellsOn_02(HandleRef pThis);

		public virtual void ExtractBoundaryCellsOn()
		{
			vtkExtractGeometry.vtkExtractGeometry_ExtractBoundaryCellsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGeometry_ExtractInsideOff_03(HandleRef pThis);

		public virtual void ExtractInsideOff()
		{
			vtkExtractGeometry.vtkExtractGeometry_ExtractInsideOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGeometry_ExtractInsideOn_04(HandleRef pThis);

		public virtual void ExtractInsideOn()
		{
			vtkExtractGeometry.vtkExtractGeometry_ExtractInsideOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGeometry_ExtractOnlyBoundaryCellsOff_05(HandleRef pThis);

		public virtual void ExtractOnlyBoundaryCellsOff()
		{
			vtkExtractGeometry.vtkExtractGeometry_ExtractOnlyBoundaryCellsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGeometry_ExtractOnlyBoundaryCellsOn_06(HandleRef pThis);

		public virtual void ExtractOnlyBoundaryCellsOn()
		{
			vtkExtractGeometry.vtkExtractGeometry_ExtractOnlyBoundaryCellsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractGeometry_GetExtractBoundaryCells_07(HandleRef pThis);

		public virtual int GetExtractBoundaryCells()
		{
			return vtkExtractGeometry.vtkExtractGeometry_GetExtractBoundaryCells_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractGeometry_GetExtractInside_08(HandleRef pThis);

		public virtual int GetExtractInside()
		{
			return vtkExtractGeometry.vtkExtractGeometry_GetExtractInside_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractGeometry_GetExtractOnlyBoundaryCells_09(HandleRef pThis);

		public virtual int GetExtractOnlyBoundaryCells()
		{
			return vtkExtractGeometry.vtkExtractGeometry_GetExtractOnlyBoundaryCells_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractGeometry_GetImplicitFunction_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractGeometry.vtkExtractGeometry_GetImplicitFunction_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkExtractGeometry_GetMTime_11(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkExtractGeometry.vtkExtractGeometry_GetMTime_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractGeometry_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractGeometry.vtkExtractGeometry_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractGeometry_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractGeometry.vtkExtractGeometry_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractGeometry_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractGeometry NewInstance()
		{
			vtkExtractGeometry result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractGeometry.vtkExtractGeometry_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractGeometry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractGeometry_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractGeometry SafeDownCast(vtkObjectBase o)
		{
			vtkExtractGeometry vtkExtractGeometry = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractGeometry.vtkExtractGeometry_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractGeometry = (vtkExtractGeometry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractGeometry.Register(null);
				}
			}
			return vtkExtractGeometry;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGeometry_SetExtractBoundaryCells_17(HandleRef pThis, int _arg);

		public virtual void SetExtractBoundaryCells(int _arg)
		{
			vtkExtractGeometry.vtkExtractGeometry_SetExtractBoundaryCells_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGeometry_SetExtractInside_18(HandleRef pThis, int _arg);

		public virtual void SetExtractInside(int _arg)
		{
			vtkExtractGeometry.vtkExtractGeometry_SetExtractInside_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGeometry_SetExtractOnlyBoundaryCells_19(HandleRef pThis, int _arg);

		public virtual void SetExtractOnlyBoundaryCells(int _arg)
		{
			vtkExtractGeometry.vtkExtractGeometry_SetExtractOnlyBoundaryCells_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractGeometry_SetImplicitFunction_20(HandleRef pThis, HandleRef arg0);

		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtkExtractGeometry.vtkExtractGeometry_SetImplicitFunction_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
