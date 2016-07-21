using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransmitStructuredGridPiece : vtkStructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransmitStructuredGridPiece";

		public new static readonly string MRClassNameKey;

		static vtkTransmitStructuredGridPiece()
		{
			vtkTransmitStructuredGridPiece.MRClassNameKey = "class vtkTransmitStructuredGridPiece";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransmitStructuredGridPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransmitStructuredGridPiece"));
		}

		public vtkTransmitStructuredGridPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitStructuredGridPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransmitStructuredGridPiece New()
		{
			vtkTransmitStructuredGridPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitStructuredGridPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransmitStructuredGridPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitStructuredGridPiece_CreateGhostCellsOff_01(HandleRef pThis);

		public virtual void CreateGhostCellsOff()
		{
			vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_CreateGhostCellsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitStructuredGridPiece_CreateGhostCellsOn_02(HandleRef pThis);

		public virtual void CreateGhostCellsOn()
		{
			vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_CreateGhostCellsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitStructuredGridPiece_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_GetController_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkTransmitStructuredGridPiece_GetCreateGhostCells_04(HandleRef pThis);

		public virtual int GetCreateGhostCells()
		{
			return vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_GetCreateGhostCells_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTransmitStructuredGridPiece_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTransmitStructuredGridPiece_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitStructuredGridPiece_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransmitStructuredGridPiece NewInstance()
		{
			vtkTransmitStructuredGridPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitStructuredGridPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitStructuredGridPiece_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransmitStructuredGridPiece SafeDownCast(vtkObjectBase o)
		{
			vtkTransmitStructuredGridPiece vtkTransmitStructuredGridPiece = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransmitStructuredGridPiece = (vtkTransmitStructuredGridPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransmitStructuredGridPiece.Register(null);
				}
			}
			return vtkTransmitStructuredGridPiece;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitStructuredGridPiece_SetController_10(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_SetController_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitStructuredGridPiece_SetCreateGhostCells_11(HandleRef pThis, int _arg);

		public virtual void SetCreateGhostCells(int _arg)
		{
			vtkTransmitStructuredGridPiece.vtkTransmitStructuredGridPiece_SetCreateGhostCells_11(base.GetCppThis(), _arg);
		}
	}
}
