using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPointDataToCellData : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointDataToCellData";

		public new static readonly string MRClassNameKey;

		static vtkPointDataToCellData()
		{
			vtkPointDataToCellData.MRClassNameKey = "class vtkPointDataToCellData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointDataToCellData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointDataToCellData"));
		}

		public vtkPointDataToCellData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPointDataToCellData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointDataToCellData New()
		{
			vtkPointDataToCellData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointDataToCellData.vtkPointDataToCellData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointDataToCellData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPointDataToCellData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPointDataToCellData.vtkPointDataToCellData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPointDataToCellData_GetPassPointData_01(HandleRef pThis);

		public virtual int GetPassPointData()
		{
			return vtkPointDataToCellData.vtkPointDataToCellData_GetPassPointData_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPointDataToCellData_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPointDataToCellData.vtkPointDataToCellData_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPointDataToCellData_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPointDataToCellData.vtkPointDataToCellData_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPointDataToCellData_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPointDataToCellData NewInstance()
		{
			vtkPointDataToCellData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointDataToCellData.vtkPointDataToCellData_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointDataToCellData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPointDataToCellData_PassPointDataOff_06(HandleRef pThis);

		public virtual void PassPointDataOff()
		{
			vtkPointDataToCellData.vtkPointDataToCellData_PassPointDataOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPointDataToCellData_PassPointDataOn_07(HandleRef pThis);

		public virtual void PassPointDataOn()
		{
			vtkPointDataToCellData.vtkPointDataToCellData_PassPointDataOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPointDataToCellData_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointDataToCellData SafeDownCast(vtkObjectBase o)
		{
			vtkPointDataToCellData vtkPointDataToCellData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointDataToCellData.vtkPointDataToCellData_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointDataToCellData = (vtkPointDataToCellData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointDataToCellData.Register(null);
				}
			}
			return vtkPointDataToCellData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPointDataToCellData_SetPassPointData_09(HandleRef pThis, int _arg);

		public virtual void SetPassPointData(int _arg)
		{
			vtkPointDataToCellData.vtkPointDataToCellData_SetPassPointData_09(base.GetCppThis(), _arg);
		}
	}
}
