using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeFieldAggregator : vtkTreeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeFieldAggregator";

		public new static readonly string MRClassNameKey;

		static vtkTreeFieldAggregator()
		{
			vtkTreeFieldAggregator.MRClassNameKey = "class vtkTreeFieldAggregator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeFieldAggregator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeFieldAggregator"));
		}

		public vtkTreeFieldAggregator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeFieldAggregator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeFieldAggregator New()
		{
			vtkTreeFieldAggregator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeFieldAggregator.vtkTreeFieldAggregator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeFieldAggregator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeFieldAggregator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeFieldAggregator.vtkTreeFieldAggregator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeFieldAggregator_GetField_01(HandleRef pThis);

		public virtual string GetField()
		{
			return Marshal.PtrToStringAnsi(vtkTreeFieldAggregator.vtkTreeFieldAggregator_GetField_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkTreeFieldAggregator_GetLeafVertexUnitSize_02(HandleRef pThis);

		public virtual bool GetLeafVertexUnitSize()
		{
			return vtkTreeFieldAggregator.vtkTreeFieldAggregator_GetLeafVertexUnitSize_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkTreeFieldAggregator_GetLogScale_03(HandleRef pThis);

		public virtual bool GetLogScale()
		{
			return vtkTreeFieldAggregator.vtkTreeFieldAggregator_GetLogScale_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeFieldAggregator_GetMinValue_04(HandleRef pThis);

		public virtual double GetMinValue()
		{
			return vtkTreeFieldAggregator.vtkTreeFieldAggregator_GetMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeFieldAggregator_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeFieldAggregator.vtkTreeFieldAggregator_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeFieldAggregator_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeFieldAggregator.vtkTreeFieldAggregator_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeFieldAggregator_LeafVertexUnitSizeOff_07(HandleRef pThis);

		public virtual void LeafVertexUnitSizeOff()
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_LeafVertexUnitSizeOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeFieldAggregator_LeafVertexUnitSizeOn_08(HandleRef pThis);

		public virtual void LeafVertexUnitSizeOn()
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_LeafVertexUnitSizeOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeFieldAggregator_LogScaleOff_09(HandleRef pThis);

		public virtual void LogScaleOff()
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_LogScaleOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeFieldAggregator_LogScaleOn_10(HandleRef pThis);

		public virtual void LogScaleOn()
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_LogScaleOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeFieldAggregator_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeFieldAggregator NewInstance()
		{
			vtkTreeFieldAggregator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeFieldAggregator.vtkTreeFieldAggregator_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeFieldAggregator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeFieldAggregator_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeFieldAggregator SafeDownCast(vtkObjectBase o)
		{
			vtkTreeFieldAggregator vtkTreeFieldAggregator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeFieldAggregator.vtkTreeFieldAggregator_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeFieldAggregator = (vtkTreeFieldAggregator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeFieldAggregator.Register(null);
				}
			}
			return vtkTreeFieldAggregator;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeFieldAggregator_SetField_14(HandleRef pThis, string _arg);

		public virtual void SetField(string _arg)
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_SetField_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeFieldAggregator_SetLeafVertexUnitSize_15(HandleRef pThis, byte _arg);

		public virtual void SetLeafVertexUnitSize(bool _arg)
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_SetLeafVertexUnitSize_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeFieldAggregator_SetLogScale_16(HandleRef pThis, byte _arg);

		public virtual void SetLogScale(bool _arg)
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_SetLogScale_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeFieldAggregator_SetMinValue_17(HandleRef pThis, double _arg);

		public virtual void SetMinValue(double _arg)
		{
			vtkTreeFieldAggregator.vtkTreeFieldAggregator_SetMinValue_17(base.GetCppThis(), _arg);
		}
	}
}
