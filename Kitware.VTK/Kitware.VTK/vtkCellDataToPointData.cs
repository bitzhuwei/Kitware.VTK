using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCellDataToPointData : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellDataToPointData";

		public new static readonly string MRClassNameKey;

		static vtkCellDataToPointData()
		{
			vtkCellDataToPointData.MRClassNameKey = "class vtkCellDataToPointData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellDataToPointData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellDataToPointData"));
		}

		public vtkCellDataToPointData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellDataToPointData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellDataToPointData New()
		{
			vtkCellDataToPointData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellDataToPointData.vtkCellDataToPointData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellDataToPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCellDataToPointData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCellDataToPointData.vtkCellDataToPointData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellDataToPointData_GetPassCellData_01(HandleRef pThis);

		public virtual int GetPassCellData()
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_GetPassCellData_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellDataToPointData_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellDataToPointData_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellDataToPointData_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCellDataToPointData NewInstance()
		{
			vtkCellDataToPointData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellDataToPointData.vtkCellDataToPointData_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellDataToPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellDataToPointData_PassCellDataOff_06(HandleRef pThis);

		public virtual void PassCellDataOff()
		{
			vtkCellDataToPointData.vtkCellDataToPointData_PassCellDataOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellDataToPointData_PassCellDataOn_07(HandleRef pThis);

		public virtual void PassCellDataOn()
		{
			vtkCellDataToPointData.vtkCellDataToPointData_PassCellDataOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellDataToPointData_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellDataToPointData SafeDownCast(vtkObjectBase o)
		{
			vtkCellDataToPointData vtkCellDataToPointData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellDataToPointData.vtkCellDataToPointData_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellDataToPointData = (vtkCellDataToPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellDataToPointData.Register(null);
				}
			}
			return vtkCellDataToPointData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellDataToPointData_SetPassCellData_09(HandleRef pThis, int _arg);

		public virtual void SetPassCellData(int _arg)
		{
			vtkCellDataToPointData.vtkCellDataToPointData_SetPassCellData_09(base.GetCppThis(), _arg);
		}
	}
}
