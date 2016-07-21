using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBlockItem : vtkContextItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBlockItem";

		public new static readonly string MRClassNameKey;

		static vtkBlockItem()
		{
			vtkBlockItem.MRClassNameKey = "class vtkBlockItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBlockItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBlockItem"));
		}

		public vtkBlockItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkBlockItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBlockItem New()
		{
			vtkBlockItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlockItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBlockItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBlockItem.vtkBlockItem_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkBlockItem_GetDimensions_01(HandleRef pThis);

		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_GetDimensions_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBlockItem_GetDimensions_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4);

		public virtual void GetDimensions(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4)
		{
			vtkBlockItem.vtkBlockItem_GetDimensions_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBlockItem_GetDimensions_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetDimensions(IntPtr _arg)
		{
			vtkBlockItem.vtkBlockItem_GetDimensions_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkBlockItem_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBlockItem.vtkBlockItem_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkBlockItem_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBlockItem.vtkBlockItem_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkBlockItem_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBlockItem NewInstance()
		{
			vtkBlockItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlockItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkBlockItem_Paint_08(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkBlockItem.vtkBlockItem_Paint_08(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkBlockItem_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBlockItem SafeDownCast(vtkObjectBase o)
		{
			vtkBlockItem vtkBlockItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBlockItem = (vtkBlockItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBlockItem.Register(null);
				}
			}
			return vtkBlockItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBlockItem_SetDimensions_10(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4);

		public virtual void SetDimensions(int _arg1, int _arg2, int _arg3, int _arg4)
		{
			vtkBlockItem.vtkBlockItem_SetDimensions_10(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBlockItem_SetDimensions_11(HandleRef pThis, IntPtr _arg);

		public virtual void SetDimensions(IntPtr _arg)
		{
			vtkBlockItem.vtkBlockItem_SetDimensions_11(base.GetCppThis(), _arg);
		}
	}
}
