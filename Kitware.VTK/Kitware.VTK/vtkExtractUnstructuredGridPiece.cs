using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractUnstructuredGridPiece : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractUnstructuredGridPiece";

		public new static readonly string MRClassNameKey;

		static vtkExtractUnstructuredGridPiece()
		{
			vtkExtractUnstructuredGridPiece.MRClassNameKey = "class vtkExtractUnstructuredGridPiece";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractUnstructuredGridPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractUnstructuredGridPiece"));
		}

		public vtkExtractUnstructuredGridPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractUnstructuredGridPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractUnstructuredGridPiece New()
		{
			vtkExtractUnstructuredGridPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractUnstructuredGridPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractUnstructuredGridPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGridPiece_CreateGhostCellsOff_01(HandleRef pThis);

		public virtual void CreateGhostCellsOff()
		{
			vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_CreateGhostCellsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGridPiece_CreateGhostCellsOn_02(HandleRef pThis);

		public virtual void CreateGhostCellsOn()
		{
			vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_CreateGhostCellsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExtractUnstructuredGridPiece_GetCreateGhostCells_03(HandleRef pThis);

		public virtual int GetCreateGhostCells()
		{
			return vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_GetCreateGhostCells_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExtractUnstructuredGridPiece_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExtractUnstructuredGridPiece_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractUnstructuredGridPiece_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractUnstructuredGridPiece NewInstance()
		{
			vtkExtractUnstructuredGridPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractUnstructuredGridPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractUnstructuredGridPiece_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractUnstructuredGridPiece SafeDownCast(vtkObjectBase o)
		{
			vtkExtractUnstructuredGridPiece vtkExtractUnstructuredGridPiece = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractUnstructuredGridPiece = (vtkExtractUnstructuredGridPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractUnstructuredGridPiece.Register(null);
				}
			}
			return vtkExtractUnstructuredGridPiece;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGridPiece_SetCreateGhostCells_09(HandleRef pThis, int _arg);

		public virtual void SetCreateGhostCells(int _arg)
		{
			vtkExtractUnstructuredGridPiece.vtkExtractUnstructuredGridPiece_SetCreateGhostCells_09(base.GetCppThis(), _arg);
		}
	}
}
