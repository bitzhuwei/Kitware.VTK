using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkKdTreeSelector : vtkSelectionAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkKdTreeSelector";

		public new static readonly string MRClassNameKey;

		static vtkKdTreeSelector()
		{
			vtkKdTreeSelector.MRClassNameKey = "class vtkKdTreeSelector";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKdTreeSelector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKdTreeSelector"));
		}

		public vtkKdTreeSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTreeSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKdTreeSelector New()
		{
			vtkKdTreeSelector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTreeSelector.vtkKdTreeSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdTreeSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkKdTreeSelector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkKdTreeSelector.vtkKdTreeSelector_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTreeSelector_GetKdTree_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkKdTree GetKdTree()
		{
			vtkKdTree vtkKdTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTreeSelector.vtkKdTreeSelector_GetKdTree_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdTree = (vtkKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdTree.Register(null);
				}
			}
			return vtkKdTree;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkKdTreeSelector_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkKdTreeSelector_GetSelectionAttribute_03(HandleRef pThis);

		public virtual int GetSelectionAttribute()
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_GetSelectionAttribute_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTreeSelector_GetSelectionBounds_04(HandleRef pThis);

		public virtual double[] GetSelectionBounds()
		{
			IntPtr intPtr = vtkKdTreeSelector.vtkKdTreeSelector_GetSelectionBounds_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkKdTreeSelector_GetSelectionBounds_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		public virtual void GetSelectionBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_GetSelectionBounds_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkKdTreeSelector_GetSelectionBounds_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetSelectionBounds(IntPtr _arg)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_GetSelectionBounds_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTreeSelector_GetSelectionFieldName_07(HandleRef pThis);

		public virtual string GetSelectionFieldName()
		{
			return Marshal.PtrToStringAnsi(vtkKdTreeSelector.vtkKdTreeSelector_GetSelectionFieldName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkKdTreeSelector_GetSingleSelection_08(HandleRef pThis);

		public virtual bool GetSingleSelection()
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_GetSingleSelection_08(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkKdTreeSelector_GetSingleSelectionThreshold_09(HandleRef pThis);

		public virtual double GetSingleSelectionThreshold()
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_GetSingleSelectionThreshold_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkKdTreeSelector_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkKdTreeSelector_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTreeSelector_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkKdTreeSelector NewInstance()
		{
			vtkKdTreeSelector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTreeSelector.vtkKdTreeSelector_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdTreeSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTreeSelector_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKdTreeSelector SafeDownCast(vtkObjectBase o)
		{
			vtkKdTreeSelector vtkKdTreeSelector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTreeSelector.vtkKdTreeSelector_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdTreeSelector = (vtkKdTreeSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdTreeSelector.Register(null);
				}
			}
			return vtkKdTreeSelector;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkKdTreeSelector_SetKdTree_15(HandleRef pThis, HandleRef tree);

		public void SetKdTree(vtkKdTree tree)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetKdTree_15(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkKdTreeSelector_SetSelectionAttribute_16(HandleRef pThis, int _arg);

		public virtual void SetSelectionAttribute(int _arg)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetSelectionAttribute_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkKdTreeSelector_SetSelectionBounds_17(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetSelectionBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetSelectionBounds_17(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkKdTreeSelector_SetSelectionBounds_18(HandleRef pThis, IntPtr _arg);

		public virtual void SetSelectionBounds(IntPtr _arg)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetSelectionBounds_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkKdTreeSelector_SetSelectionFieldName_19(HandleRef pThis, string _arg);

		public virtual void SetSelectionFieldName(string _arg)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetSelectionFieldName_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkKdTreeSelector_SetSingleSelection_20(HandleRef pThis, byte _arg);

		public virtual void SetSingleSelection(bool _arg)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetSingleSelection_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkKdTreeSelector_SetSingleSelectionThreshold_21(HandleRef pThis, double _arg);

		public virtual void SetSingleSelectionThreshold(double _arg)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetSingleSelectionThreshold_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkKdTreeSelector_SingleSelectionOff_22(HandleRef pThis);

		public virtual void SingleSelectionOff()
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SingleSelectionOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkKdTreeSelector_SingleSelectionOn_23(HandleRef pThis);

		public virtual void SingleSelectionOn()
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SingleSelectionOn_23(base.GetCppThis());
		}
	}
}
