using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageItem : vtkContextItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageItem";

		public new static readonly string MRClassNameKey;

		static vtkImageItem()
		{
			vtkImageItem.MRClassNameKey = "class vtkImageItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageItem"));
		}

		public vtkImageItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkImageItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageItem New()
		{
			vtkImageItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageItem.vtkImageItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageItem.vtkImageItem_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkImageItem_GetImage_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageItem.vtkImageItem_GetImage_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkImageItem_GetPosition_02(HandleRef pThis);

		public virtual float[] GetPosition()
		{
			IntPtr intPtr = vtkImageItem.vtkImageItem_GetPosition_02(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkImageItem_GetPosition_03(HandleRef pThis, ref float _arg1, ref float _arg2);

		public virtual void GetPosition(ref float _arg1, ref float _arg2)
		{
			vtkImageItem.vtkImageItem_GetPosition_03(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkImageItem_GetPosition_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetPosition(IntPtr _arg)
		{
			vtkImageItem.vtkImageItem_GetPosition_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkImageItem_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageItem.vtkImageItem_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkImageItem_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageItem.vtkImageItem_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkImageItem_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageItem NewInstance()
		{
			vtkImageItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageItem.vtkImageItem_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkImageItem_Paint_09(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkImageItem.vtkImageItem_Paint_09(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkImageItem_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageItem SafeDownCast(vtkObjectBase o)
		{
			vtkImageItem vtkImageItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageItem.vtkImageItem_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageItem = (vtkImageItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageItem.Register(null);
				}
			}
			return vtkImageItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkImageItem_SetImage_11(HandleRef pThis, HandleRef image);

		public void SetImage(vtkImageData image)
		{
			vtkImageItem.vtkImageItem_SetImage_11(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkImageItem_SetPosition_12(HandleRef pThis, float _arg1, float _arg2);

		public virtual void SetPosition(float _arg1, float _arg2)
		{
			vtkImageItem.vtkImageItem_SetPosition_12(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkImageItem_SetPosition_13(HandleRef pThis, IntPtr _arg);

		public void SetPosition(IntPtr _arg)
		{
			vtkImageItem.vtkImageItem_SetPosition_13(base.GetCppThis(), _arg);
		}
	}
}
