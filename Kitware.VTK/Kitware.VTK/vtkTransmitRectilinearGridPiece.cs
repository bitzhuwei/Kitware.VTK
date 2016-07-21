using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransmitRectilinearGridPiece : vtkRectilinearGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransmitRectilinearGridPiece";

		public new static readonly string MRClassNameKey;

		static vtkTransmitRectilinearGridPiece()
		{
			vtkTransmitRectilinearGridPiece.MRClassNameKey = "class vtkTransmitRectilinearGridPiece";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransmitRectilinearGridPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransmitRectilinearGridPiece"));
		}

		public vtkTransmitRectilinearGridPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitRectilinearGridPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransmitRectilinearGridPiece New()
		{
			vtkTransmitRectilinearGridPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitRectilinearGridPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransmitRectilinearGridPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitRectilinearGridPiece_CreateGhostCellsOff_01(HandleRef pThis);

		public virtual void CreateGhostCellsOff()
		{
			vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_CreateGhostCellsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitRectilinearGridPiece_CreateGhostCellsOn_02(HandleRef pThis);

		public virtual void CreateGhostCellsOn()
		{
			vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_CreateGhostCellsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitRectilinearGridPiece_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_GetController_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTransmitRectilinearGridPiece_GetCreateGhostCells_04(HandleRef pThis);

		public virtual int GetCreateGhostCells()
		{
			return vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_GetCreateGhostCells_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTransmitRectilinearGridPiece_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTransmitRectilinearGridPiece_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitRectilinearGridPiece_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransmitRectilinearGridPiece NewInstance()
		{
			vtkTransmitRectilinearGridPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitRectilinearGridPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitRectilinearGridPiece_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransmitRectilinearGridPiece SafeDownCast(vtkObjectBase o)
		{
			vtkTransmitRectilinearGridPiece vtkTransmitRectilinearGridPiece = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransmitRectilinearGridPiece = (vtkTransmitRectilinearGridPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransmitRectilinearGridPiece.Register(null);
				}
			}
			return vtkTransmitRectilinearGridPiece;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitRectilinearGridPiece_SetController_10(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_SetController_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitRectilinearGridPiece_SetCreateGhostCells_11(HandleRef pThis, int _arg);

		public virtual void SetCreateGhostCells(int _arg)
		{
			vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_SetCreateGhostCells_11(base.GetCppThis(), _arg);
		}
	}
}
