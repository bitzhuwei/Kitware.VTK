using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTableToPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToPolyData";

		public new static readonly string MRClassNameKey;

		static vtkTableToPolyData()
		{
			vtkTableToPolyData.MRClassNameKey = "class vtkTableToPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToPolyData"));
		}

		public vtkTableToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableToPolyData New()
		{
			vtkTableToPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToPolyData.vtkTableToPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTableToPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTableToPolyData.vtkTableToPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToPolyData_Create2DPointsOff_01(HandleRef pThis);

		public virtual void Create2DPointsOff()
		{
			vtkTableToPolyData.vtkTableToPolyData_Create2DPointsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToPolyData_Create2DPointsOn_02(HandleRef pThis);

		public virtual void Create2DPointsOn()
		{
			vtkTableToPolyData.vtkTableToPolyData_Create2DPointsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkTableToPolyData_GetCreate2DPoints_03(HandleRef pThis);

		public virtual bool GetCreate2DPoints()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetCreate2DPoints_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToPolyData_GetXColumn_04(HandleRef pThis);

		public virtual string GetXColumn()
		{
			return Marshal.PtrToStringAnsi(vtkTableToPolyData.vtkTableToPolyData_GetXColumn_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetXColumnIndex_05(HandleRef pThis);

		public virtual int GetXColumnIndex()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetXColumnIndex_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetXColumnIndexMaxValue_06(HandleRef pThis);

		public virtual int GetXColumnIndexMaxValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetXColumnIndexMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetXColumnIndexMinValue_07(HandleRef pThis);

		public virtual int GetXColumnIndexMinValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetXColumnIndexMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetXComponent_08(HandleRef pThis);

		public virtual int GetXComponent()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetXComponent_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetXComponentMaxValue_09(HandleRef pThis);

		public virtual int GetXComponentMaxValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetXComponentMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetXComponentMinValue_10(HandleRef pThis);

		public virtual int GetXComponentMinValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetXComponentMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToPolyData_GetYColumn_11(HandleRef pThis);

		public virtual string GetYColumn()
		{
			return Marshal.PtrToStringAnsi(vtkTableToPolyData.vtkTableToPolyData_GetYColumn_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetYColumnIndex_12(HandleRef pThis);

		public virtual int GetYColumnIndex()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetYColumnIndex_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetYColumnIndexMaxValue_13(HandleRef pThis);

		public virtual int GetYColumnIndexMaxValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetYColumnIndexMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetYColumnIndexMinValue_14(HandleRef pThis);

		public virtual int GetYColumnIndexMinValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetYColumnIndexMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetYComponent_15(HandleRef pThis);

		public virtual int GetYComponent()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetYComponent_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetYComponentMaxValue_16(HandleRef pThis);

		public virtual int GetYComponentMaxValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetYComponentMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetYComponentMinValue_17(HandleRef pThis);

		public virtual int GetYComponentMinValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetYComponentMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToPolyData_GetZColumn_18(HandleRef pThis);

		public virtual string GetZColumn()
		{
			return Marshal.PtrToStringAnsi(vtkTableToPolyData.vtkTableToPolyData_GetZColumn_18(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetZColumnIndex_19(HandleRef pThis);

		public virtual int GetZColumnIndex()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetZColumnIndex_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetZColumnIndexMaxValue_20(HandleRef pThis);

		public virtual int GetZColumnIndexMaxValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetZColumnIndexMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetZColumnIndexMinValue_21(HandleRef pThis);

		public virtual int GetZColumnIndexMinValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetZColumnIndexMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetZComponent_22(HandleRef pThis);

		public virtual int GetZComponent()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetZComponent_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetZComponentMaxValue_23(HandleRef pThis);

		public virtual int GetZComponentMaxValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetZComponentMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_GetZComponentMinValue_24(HandleRef pThis);

		public virtual int GetZComponentMinValue()
		{
			return vtkTableToPolyData.vtkTableToPolyData_GetZComponentMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTableToPolyData.vtkTableToPolyData_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToPolyData_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTableToPolyData.vtkTableToPolyData_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToPolyData_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTableToPolyData NewInstance()
		{
			vtkTableToPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToPolyData.vtkTableToPolyData_NewInstance_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToPolyData_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableToPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkTableToPolyData vtkTableToPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToPolyData.vtkTableToPolyData_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToPolyData = (vtkTableToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToPolyData.Register(null);
				}
			}
			return vtkTableToPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToPolyData_SetCreate2DPoints_30(HandleRef pThis, byte _arg);

		public virtual void SetCreate2DPoints(bool _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetCreate2DPoints_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToPolyData_SetXColumn_31(HandleRef pThis, string _arg);

		public virtual void SetXColumn(string _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetXColumn_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToPolyData_SetXColumnIndex_32(HandleRef pThis, int _arg);

		public virtual void SetXColumnIndex(int _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetXColumnIndex_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToPolyData_SetXComponent_33(HandleRef pThis, int _arg);

		public virtual void SetXComponent(int _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetXComponent_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToPolyData_SetYColumn_34(HandleRef pThis, string _arg);

		public virtual void SetYColumn(string _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetYColumn_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToPolyData_SetYColumnIndex_35(HandleRef pThis, int _arg);

		public virtual void SetYColumnIndex(int _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetYColumnIndex_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToPolyData_SetYComponent_36(HandleRef pThis, int _arg);

		public virtual void SetYComponent(int _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetYComponent_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToPolyData_SetZColumn_37(HandleRef pThis, string _arg);

		public virtual void SetZColumn(string _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetZColumn_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToPolyData_SetZColumnIndex_38(HandleRef pThis, int _arg);

		public virtual void SetZColumnIndex(int _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetZColumnIndex_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToPolyData_SetZComponent_39(HandleRef pThis, int _arg);

		public virtual void SetZComponent(int _arg)
		{
			vtkTableToPolyData.vtkTableToPolyData_SetZComponent_39(base.GetCppThis(), _arg);
		}
	}
}
