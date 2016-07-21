using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractPolyDataPiece : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractPolyDataPiece";

		public new static readonly string MRClassNameKey;

		static vtkExtractPolyDataPiece()
		{
			vtkExtractPolyDataPiece.MRClassNameKey = "class vtkExtractPolyDataPiece";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractPolyDataPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractPolyDataPiece"));
		}

		public vtkExtractPolyDataPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractPolyDataPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractPolyDataPiece New()
		{
			vtkExtractPolyDataPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPolyDataPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractPolyDataPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractPolyDataPiece_CreateGhostCellsOff_01(HandleRef pThis);

		public virtual void CreateGhostCellsOff()
		{
			vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_CreateGhostCellsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractPolyDataPiece_CreateGhostCellsOn_02(HandleRef pThis);

		public virtual void CreateGhostCellsOn()
		{
			vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_CreateGhostCellsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExtractPolyDataPiece_GetCreateGhostCells_03(HandleRef pThis);

		public virtual int GetCreateGhostCells()
		{
			return vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_GetCreateGhostCells_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExtractPolyDataPiece_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExtractPolyDataPiece_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractPolyDataPiece_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractPolyDataPiece NewInstance()
		{
			vtkExtractPolyDataPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPolyDataPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractPolyDataPiece_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractPolyDataPiece SafeDownCast(vtkObjectBase o)
		{
			vtkExtractPolyDataPiece vtkExtractPolyDataPiece = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractPolyDataPiece = (vtkExtractPolyDataPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractPolyDataPiece.Register(null);
				}
			}
			return vtkExtractPolyDataPiece;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractPolyDataPiece_SetCreateGhostCells_09(HandleRef pThis, int _arg);

		public virtual void SetCreateGhostCells(int _arg)
		{
			vtkExtractPolyDataPiece.vtkExtractPolyDataPiece_SetCreateGhostCells_09(base.GetCppThis(), _arg);
		}
	}
}
