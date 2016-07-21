using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransmitImageDataPiece : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransmitImageDataPiece";

		public new static readonly string MRClassNameKey;

		static vtkTransmitImageDataPiece()
		{
			vtkTransmitImageDataPiece.MRClassNameKey = "class vtkTransmitImageDataPiece";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransmitImageDataPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransmitImageDataPiece"));
		}

		public vtkTransmitImageDataPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitImageDataPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransmitImageDataPiece New()
		{
			vtkTransmitImageDataPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitImageDataPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransmitImageDataPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitImageDataPiece_CreateGhostCellsOff_01(HandleRef pThis);

		public virtual void CreateGhostCellsOff()
		{
			vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_CreateGhostCellsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitImageDataPiece_CreateGhostCellsOn_02(HandleRef pThis);

		public virtual void CreateGhostCellsOn()
		{
			vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_CreateGhostCellsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitImageDataPiece_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_GetController_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkTransmitImageDataPiece_GetCreateGhostCells_04(HandleRef pThis);

		public virtual int GetCreateGhostCells()
		{
			return vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_GetCreateGhostCells_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTransmitImageDataPiece_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTransmitImageDataPiece_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitImageDataPiece_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransmitImageDataPiece NewInstance()
		{
			vtkTransmitImageDataPiece result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitImageDataPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTransmitImageDataPiece_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransmitImageDataPiece SafeDownCast(vtkObjectBase o)
		{
			vtkTransmitImageDataPiece vtkTransmitImageDataPiece = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransmitImageDataPiece = (vtkTransmitImageDataPiece)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransmitImageDataPiece.Register(null);
				}
			}
			return vtkTransmitImageDataPiece;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitImageDataPiece_SetController_10(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_SetController_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTransmitImageDataPiece_SetCreateGhostCells_11(HandleRef pThis, int _arg);

		public virtual void SetCreateGhostCells(int _arg)
		{
			vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_SetCreateGhostCells_11(base.GetCppThis(), _arg);
		}
	}
}
