using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPCellDataToPointData : vtkCellDataToPointData
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPCellDataToPointData";

		public new static readonly string MRClassNameKey;

		static vtkPCellDataToPointData()
		{
			vtkPCellDataToPointData.MRClassNameKey = "class vtkPCellDataToPointData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPCellDataToPointData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCellDataToPointData"));
		}

		public vtkPCellDataToPointData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPCellDataToPointData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPCellDataToPointData New()
		{
			vtkPCellDataToPointData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCellDataToPointData.vtkPCellDataToPointData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCellDataToPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPCellDataToPointData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPCellDataToPointData.vtkPCellDataToPointData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCellDataToPointData_GetPieceInvariant_01(HandleRef pThis);

		public virtual int GetPieceInvariant()
		{
			return vtkPCellDataToPointData.vtkPCellDataToPointData_GetPieceInvariant_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCellDataToPointData_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPCellDataToPointData.vtkPCellDataToPointData_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPCellDataToPointData_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPCellDataToPointData.vtkPCellDataToPointData_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPCellDataToPointData_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPCellDataToPointData NewInstance()
		{
			vtkPCellDataToPointData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCellDataToPointData.vtkPCellDataToPointData_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCellDataToPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCellDataToPointData_PieceInvariantOff_06(HandleRef pThis);

		public virtual void PieceInvariantOff()
		{
			vtkPCellDataToPointData.vtkPCellDataToPointData_PieceInvariantOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCellDataToPointData_PieceInvariantOn_07(HandleRef pThis);

		public virtual void PieceInvariantOn()
		{
			vtkPCellDataToPointData.vtkPCellDataToPointData_PieceInvariantOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPCellDataToPointData_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPCellDataToPointData SafeDownCast(vtkObjectBase o)
		{
			vtkPCellDataToPointData vtkPCellDataToPointData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCellDataToPointData.vtkPCellDataToPointData_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPCellDataToPointData = (vtkPCellDataToPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPCellDataToPointData.Register(null);
				}
			}
			return vtkPCellDataToPointData;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPCellDataToPointData_SetPieceInvariant_09(HandleRef pThis, int _arg);

		public virtual void SetPieceInvariant(int _arg)
		{
			vtkPCellDataToPointData.vtkPCellDataToPointData_SetPieceInvariant_09(base.GetCppThis(), _arg);
		}
	}
}
