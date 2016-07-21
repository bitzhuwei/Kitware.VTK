using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTooltipItem : vtkContextItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTooltipItem";

		public new static readonly string MRClassNameKey;

		static vtkTooltipItem()
		{
			vtkTooltipItem.MRClassNameKey = "class vtkTooltipItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTooltipItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTooltipItem"));
		}

		public vtkTooltipItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkTooltipItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTooltipItem New()
		{
			vtkTooltipItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTooltipItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTooltipItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTooltipItem.vtkTooltipItem_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkTooltipItem_GetBrush_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkBrush GetBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_GetBrush_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrush = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrush.Register(null);
				}
			}
			return vtkBrush;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkTooltipItem_GetPen_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_GetPen_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkTooltipItem_GetPosition_03(HandleRef pThis);

		public virtual float[] GetPosition()
		{
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_GetPosition_03(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkTooltipItem_GetPosition_04(HandleRef pThis, ref float _arg1, ref float _arg2);

		public virtual void GetPosition(ref float _arg1, ref float _arg2)
		{
			vtkTooltipItem.vtkTooltipItem_GetPosition_04(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkTooltipItem_GetPosition_05(HandleRef pThis, IntPtr _arg);

		public virtual void GetPosition(IntPtr _arg)
		{
			vtkTooltipItem.vtkTooltipItem_GetPosition_05(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkTooltipItem_GetTextProperties_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTextProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_GetTextProperties_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkTooltipItem_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTooltipItem.vtkTooltipItem_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkTooltipItem_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTooltipItem.vtkTooltipItem_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkTooltipItem_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTooltipItem NewInstance()
		{
			vtkTooltipItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTooltipItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkTooltipItem_Paint_11(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkTooltipItem.vtkTooltipItem_Paint_11(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkTooltipItem_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTooltipItem SafeDownCast(vtkObjectBase o)
		{
			vtkTooltipItem vtkTooltipItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTooltipItem = (vtkTooltipItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTooltipItem.Register(null);
				}
			}
			return vtkTooltipItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkTooltipItem_SetPosition_13(HandleRef pThis, float _arg1, float _arg2);

		public virtual void SetPosition(float _arg1, float _arg2)
		{
			vtkTooltipItem.vtkTooltipItem_SetPosition_13(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkTooltipItem_SetPosition_14(HandleRef pThis, IntPtr _arg);

		public void SetPosition(IntPtr _arg)
		{
			vtkTooltipItem.vtkTooltipItem_SetPosition_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkTooltipItem_Update_15(HandleRef pThis);

		public override void Update()
		{
			vtkTooltipItem.vtkTooltipItem_Update_15(base.GetCppThis());
		}
	}
}
