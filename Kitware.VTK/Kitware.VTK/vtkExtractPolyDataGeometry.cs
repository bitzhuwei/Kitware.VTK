using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractPolyDataGeometry : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractPolyDataGeometry";

		public new static readonly string MRClassNameKey;

		static vtkExtractPolyDataGeometry()
		{
			vtkExtractPolyDataGeometry.MRClassNameKey = "class vtkExtractPolyDataGeometry";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractPolyDataGeometry.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractPolyDataGeometry"));
		}

		public vtkExtractPolyDataGeometry(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractPolyDataGeometry_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractPolyDataGeometry New()
		{
			vtkExtractPolyDataGeometry result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPolyDataGeometry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractPolyDataGeometry() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractPolyDataGeometry_ExtractBoundaryCellsOff_01(HandleRef pThis);

		public virtual void ExtractBoundaryCellsOff()
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_ExtractBoundaryCellsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractPolyDataGeometry_ExtractBoundaryCellsOn_02(HandleRef pThis);

		public virtual void ExtractBoundaryCellsOn()
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_ExtractBoundaryCellsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractPolyDataGeometry_ExtractInsideOff_03(HandleRef pThis);

		public virtual void ExtractInsideOff()
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_ExtractInsideOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractPolyDataGeometry_ExtractInsideOn_04(HandleRef pThis);

		public virtual void ExtractInsideOn()
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_ExtractInsideOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractPolyDataGeometry_GetExtractBoundaryCells_05(HandleRef pThis);

		public virtual int GetExtractBoundaryCells()
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_GetExtractBoundaryCells_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractPolyDataGeometry_GetExtractInside_06(HandleRef pThis);

		public virtual int GetExtractInside()
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_GetExtractInside_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractPolyDataGeometry_GetImplicitFunction_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_GetImplicitFunction_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkExtractPolyDataGeometry_GetMTime_08(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_GetMTime_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractPolyDataGeometry_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractPolyDataGeometry_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractPolyDataGeometry_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractPolyDataGeometry NewInstance()
		{
			vtkExtractPolyDataGeometry result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPolyDataGeometry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractPolyDataGeometry_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractPolyDataGeometry SafeDownCast(vtkObjectBase o)
		{
			vtkExtractPolyDataGeometry vtkExtractPolyDataGeometry = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractPolyDataGeometry = (vtkExtractPolyDataGeometry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractPolyDataGeometry.Register(null);
				}
			}
			return vtkExtractPolyDataGeometry;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractPolyDataGeometry_SetExtractBoundaryCells_14(HandleRef pThis, int _arg);

		public virtual void SetExtractBoundaryCells(int _arg)
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_SetExtractBoundaryCells_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractPolyDataGeometry_SetExtractInside_15(HandleRef pThis, int _arg);

		public virtual void SetExtractInside(int _arg)
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_SetExtractInside_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractPolyDataGeometry_SetImplicitFunction_16(HandleRef pThis, HandleRef arg0);

		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_SetImplicitFunction_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
