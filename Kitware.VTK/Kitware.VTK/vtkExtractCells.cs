using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractCells : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractCells";

		public new static readonly string MRClassNameKey;

		static vtkExtractCells()
		{
			vtkExtractCells.MRClassNameKey = "class vtkExtractCells";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractCells.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractCells"));
		}

		public vtkExtractCells(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractCells_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractCells New()
		{
			vtkExtractCells result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractCells.vtkExtractCells_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractCells)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractCells() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractCells.vtkExtractCells_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractCells_AddCellList_01(HandleRef pThis, HandleRef l);

		public void AddCellList(vtkIdList l)
		{
			vtkExtractCells.vtkExtractCells_AddCellList_01(base.GetCppThis(), (l == null) ? default(HandleRef) : l.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractCells_AddCellRange_02(HandleRef pThis, long from, long to);

		public void AddCellRange(long from, long to)
		{
			vtkExtractCells.vtkExtractCells_AddCellRange_02(base.GetCppThis(), from, to);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractCells_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractCells.vtkExtractCells_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractCells_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractCells.vtkExtractCells_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractCells_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractCells NewInstance()
		{
			vtkExtractCells result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractCells.vtkExtractCells_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractCells)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractCells_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractCells SafeDownCast(vtkObjectBase o)
		{
			vtkExtractCells vtkExtractCells = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractCells.vtkExtractCells_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractCells = (vtkExtractCells)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractCells.Register(null);
				}
			}
			return vtkExtractCells;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractCells_SetCellList_08(HandleRef pThis, HandleRef l);

		public void SetCellList(vtkIdList l)
		{
			vtkExtractCells.vtkExtractCells_SetCellList_08(base.GetCppThis(), (l == null) ? default(HandleRef) : l.GetCppThis());
		}
	}
}
