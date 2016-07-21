using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRectilinearGridToTetrahedra : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridToTetrahedra";

		public new static readonly string MRClassNameKey;

		static vtkRectilinearGridToTetrahedra()
		{
			vtkRectilinearGridToTetrahedra.MRClassNameKey = "class vtkRectilinearGridToTetrahedra";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridToTetrahedra.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridToTetrahedra"));
		}

		public vtkRectilinearGridToTetrahedra(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridToTetrahedra_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearGridToTetrahedra New()
		{
			vtkRectilinearGridToTetrahedra result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridToTetrahedra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRectilinearGridToTetrahedra() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearGridToTetrahedra_GetRememberVoxelId_01(HandleRef pThis);

		public virtual int GetRememberVoxelId()
		{
			return vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_GetRememberVoxelId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearGridToTetrahedra_GetTetraPerCell_02(HandleRef pThis);

		public virtual int GetTetraPerCell()
		{
			return vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_GetTetraPerCell_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearGridToTetrahedra_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearGridToTetrahedra_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridToTetrahedra_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRectilinearGridToTetrahedra NewInstance()
		{
			vtkRectilinearGridToTetrahedra result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridToTetrahedra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridToTetrahedra_RememberVoxelIdOff_07(HandleRef pThis);

		public virtual void RememberVoxelIdOff()
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_RememberVoxelIdOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridToTetrahedra_RememberVoxelIdOn_08(HandleRef pThis);

		public virtual void RememberVoxelIdOn()
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_RememberVoxelIdOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridToTetrahedra_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearGridToTetrahedra SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridToTetrahedra vtkRectilinearGridToTetrahedra = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridToTetrahedra = (vtkRectilinearGridToTetrahedra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridToTetrahedra.Register(null);
				}
			}
			return vtkRectilinearGridToTetrahedra;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridToTetrahedra_SetInput_10(HandleRef pThis, IntPtr Extent, IntPtr Spacing, double tol);

		public void SetInput(IntPtr Extent, IntPtr Spacing, double tol)
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetInput_10(base.GetCppThis(), Extent, Spacing, tol);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridToTetrahedra_SetInput_11(HandleRef pThis, double ExtentX, double ExtentY, double ExtentZ, double SpacingX, double SpacingY, double SpacingZ, double tol);

		public void SetInput(double ExtentX, double ExtentY, double ExtentZ, double SpacingX, double SpacingY, double SpacingZ, double tol)
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetInput_11(base.GetCppThis(), ExtentX, ExtentY, ExtentZ, SpacingX, SpacingY, SpacingZ, tol);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridToTetrahedra_SetRememberVoxelId_12(HandleRef pThis, int _arg);

		public virtual void SetRememberVoxelId(int _arg)
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetRememberVoxelId_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCell_13(HandleRef pThis, int _arg);

		public virtual void SetTetraPerCell(int _arg)
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetTetraPerCell_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCellTo12_14(HandleRef pThis);

		public void SetTetraPerCellTo12()
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetTetraPerCellTo12_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCellTo5_15(HandleRef pThis);

		public void SetTetraPerCellTo5()
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetTetraPerCellTo5_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCellTo5And12_16(HandleRef pThis);

		public void SetTetraPerCellTo5And12()
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetTetraPerCellTo5And12_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCellTo6_17(HandleRef pThis);

		public void SetTetraPerCellTo6()
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetTetraPerCellTo6_17(base.GetCppThis());
		}
	}
}
