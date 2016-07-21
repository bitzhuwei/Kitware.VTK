using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkContextItem : vtkAbstractContextItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextItem";

		public new static readonly string MRClassNameKey;

		static vtkContextItem()
		{
			vtkContextItem.MRClassNameKey = "class vtkContextItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextItem"));
		}

		public vtkContextItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern double vtkContextItem_GetOpacity_01(HandleRef pThis);

		public virtual double GetOpacity()
		{
			return vtkContextItem.vtkContextItem_GetOpacity_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextItem_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContextItem.vtkContextItem_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextItem_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContextItem.vtkContextItem_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextItem_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContextItem NewInstance()
		{
			vtkContextItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextItem.vtkContextItem_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextItem_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContextItem SafeDownCast(vtkObjectBase o)
		{
			vtkContextItem vtkContextItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextItem.vtkContextItem_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextItem = (vtkContextItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextItem.Register(null);
				}
			}
			return vtkContextItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextItem_SetOpacity_06(HandleRef pThis, double _arg);

		public virtual void SetOpacity(double _arg)
		{
			vtkContextItem.vtkContextItem_SetOpacity_06(base.GetCppThis(), _arg);
		}
	}
}
