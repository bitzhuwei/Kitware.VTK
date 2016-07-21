using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphLayout : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphLayout";

		public new static readonly string MRClassNameKey;

		static vtkGraphLayout()
		{
			vtkGraphLayout.MRClassNameKey = "class vtkGraphLayout";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphLayout.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphLayout"));
		}

		public vtkGraphLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphLayout New()
		{
			vtkGraphLayout result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayout.vtkGraphLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphLayout() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphLayout.vtkGraphLayout_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayout_GetLayoutStrategy_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGraphLayoutStrategy GetLayoutStrategy()
		{
			vtkGraphLayoutStrategy vtkGraphLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayout.vtkGraphLayout_GetLayoutStrategy_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayoutStrategy = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayoutStrategy.Register(null);
				}
			}
			return vtkGraphLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern uint vtkGraphLayout_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGraphLayout.vtkGraphLayout_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayout_GetTransform_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayout.vtkGraphLayout_GetTransform_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkGraphLayout_GetUseTransform_04(HandleRef pThis);

		public virtual bool GetUseTransform()
		{
			return vtkGraphLayout.vtkGraphLayout_GetUseTransform_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkGraphLayout_GetZRange_05(HandleRef pThis);

		public virtual double GetZRange()
		{
			return vtkGraphLayout.vtkGraphLayout_GetZRange_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGraphLayout_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphLayout.vtkGraphLayout_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGraphLayout_IsLayoutComplete_07(HandleRef pThis);

		public virtual int IsLayoutComplete()
		{
			return vtkGraphLayout.vtkGraphLayout_IsLayoutComplete_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGraphLayout_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphLayout.vtkGraphLayout_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayout_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphLayout NewInstance()
		{
			vtkGraphLayout result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayout.vtkGraphLayout_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayout_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphLayout SafeDownCast(vtkObjectBase o)
		{
			vtkGraphLayout vtkGraphLayout = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayout.vtkGraphLayout_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayout = (vtkGraphLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayout.Register(null);
				}
			}
			return vtkGraphLayout;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphLayout_SetLayoutStrategy_12(HandleRef pThis, HandleRef strategy);

		public void SetLayoutStrategy(vtkGraphLayoutStrategy strategy)
		{
			vtkGraphLayout.vtkGraphLayout_SetLayoutStrategy_12(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphLayout_SetTransform_13(HandleRef pThis, HandleRef t);

		public virtual void SetTransform(vtkAbstractTransform t)
		{
			vtkGraphLayout.vtkGraphLayout_SetTransform_13(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphLayout_SetUseTransform_14(HandleRef pThis, byte _arg);

		public virtual void SetUseTransform(bool _arg)
		{
			vtkGraphLayout.vtkGraphLayout_SetUseTransform_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphLayout_SetZRange_15(HandleRef pThis, double _arg);

		public virtual void SetZRange(double _arg)
		{
			vtkGraphLayout.vtkGraphLayout_SetZRange_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphLayout_UseTransformOff_16(HandleRef pThis);

		public virtual void UseTransformOff()
		{
			vtkGraphLayout.vtkGraphLayout_UseTransformOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGraphLayout_UseTransformOn_17(HandleRef pThis);

		public virtual void UseTransformOn()
		{
			vtkGraphLayout.vtkGraphLayout_UseTransformOn_17(base.GetCppThis());
		}
	}
}
