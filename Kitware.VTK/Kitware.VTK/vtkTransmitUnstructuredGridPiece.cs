using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransmitUnstructuredGridPiece : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransmitUnstructuredGridPiece";

		public new static readonly string MRClassNameKey;

		static vtkTransmitUnstructuredGridPiece()
		{
			vtkTransmitUnstructuredGridPiece.MRClassNameKey = "class vtkTransmitUnstructuredGridPiece";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransmitUnstructuredGridPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransmitUnstructuredGridPiece"));
		}

		public vtkTransmitUnstructuredGridPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitUnstructuredGridPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransmitUnstructuredGridPiece New()
		{
			vtkTransmitUnstructuredGridPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitUnstructuredGridPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransmitUnstructuredGridPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitUnstructuredGridPiece_CreateGhostCellsOff_01(HandleRef pThis);

		public virtual void CreateGhostCellsOff()
		{
			vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_CreateGhostCellsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitUnstructuredGridPiece_CreateGhostCellsOn_02(HandleRef pThis);

		public virtual void CreateGhostCellsOn()
		{
			vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_CreateGhostCellsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitUnstructuredGridPiece_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_GetController_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkTransmitUnstructuredGridPiece_GetCreateGhostCells_04(HandleRef pThis);

		public virtual int GetCreateGhostCells()
		{
			return vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_GetCreateGhostCells_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTransmitUnstructuredGridPiece_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTransmitUnstructuredGridPiece_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitUnstructuredGridPiece_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransmitUnstructuredGridPiece NewInstance()
		{
			vtkTransmitUnstructuredGridPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitUnstructuredGridPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitUnstructuredGridPiece_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransmitUnstructuredGridPiece SafeDownCast(vtkObjectBase o)
		{
			vtkTransmitUnstructuredGridPiece vtkTransmitUnstructuredGridPiece = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransmitUnstructuredGridPiece = (vtkTransmitUnstructuredGridPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransmitUnstructuredGridPiece.Register(null);
				}
			}
			return vtkTransmitUnstructuredGridPiece;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitUnstructuredGridPiece_SetController_10(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_SetController_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitUnstructuredGridPiece_SetCreateGhostCells_11(HandleRef pThis, int _arg);

		public virtual void SetCreateGhostCells(int _arg)
		{
			vtkTransmitUnstructuredGridPiece.vtkTransmitUnstructuredGridPiece_SetCreateGhostCells_11(base.GetCppThis(), _arg);
		}
	}
}
