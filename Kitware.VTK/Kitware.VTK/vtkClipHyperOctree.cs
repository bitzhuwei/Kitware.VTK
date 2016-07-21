using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClipHyperOctree : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClipHyperOctree";

		public new static readonly string MRClassNameKey;

		static vtkClipHyperOctree()
		{
			vtkClipHyperOctree.MRClassNameKey = "class vtkClipHyperOctree";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClipHyperOctree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipHyperOctree"));
		}

		public vtkClipHyperOctree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipHyperOctree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipHyperOctree New()
		{
			vtkClipHyperOctree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipHyperOctree.vtkClipHyperOctree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipHyperOctree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClipHyperOctree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClipHyperOctree.vtkClipHyperOctree_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkClipHyperOctree.vtkClipHyperOctree_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_GenerateClipScalarsOff_02(HandleRef pThis);

		public virtual void GenerateClipScalarsOff()
		{
			vtkClipHyperOctree.vtkClipHyperOctree_GenerateClipScalarsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_GenerateClipScalarsOn_03(HandleRef pThis);

		public virtual void GenerateClipScalarsOn()
		{
			vtkClipHyperOctree.vtkClipHyperOctree_GenerateClipScalarsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_GenerateClippedOutputOff_04(HandleRef pThis);

		public virtual void GenerateClippedOutputOff()
		{
			vtkClipHyperOctree.vtkClipHyperOctree_GenerateClippedOutputOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_GenerateClippedOutputOn_05(HandleRef pThis);

		public virtual void GenerateClippedOutputOn()
		{
			vtkClipHyperOctree.vtkClipHyperOctree_GenerateClippedOutputOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipHyperOctree_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetClipFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipHyperOctree.vtkClipHyperOctree_GetClipFunction_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipHyperOctree_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetClippedOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipHyperOctree.vtkClipHyperOctree_GetClippedOutput_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipHyperOctree_GetGenerateClipScalars_08(HandleRef pThis);

		public virtual int GetGenerateClipScalars()
		{
			return vtkClipHyperOctree.vtkClipHyperOctree_GetGenerateClipScalars_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipHyperOctree_GetGenerateClippedOutput_09(HandleRef pThis);

		public virtual int GetGenerateClippedOutput()
		{
			return vtkClipHyperOctree.vtkClipHyperOctree_GetGenerateClippedOutput_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipHyperOctree_GetInsideOut_10(HandleRef pThis);

		public virtual int GetInsideOut()
		{
			return vtkClipHyperOctree.vtkClipHyperOctree_GetInsideOut_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipHyperOctree_GetLocator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipHyperOctree.vtkClipHyperOctree_GetLocator_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkClipHyperOctree_GetMTime_12(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkClipHyperOctree.vtkClipHyperOctree_GetMTime_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkClipHyperOctree_GetValue_13(HandleRef pThis);

		public virtual double GetValue()
		{
			return vtkClipHyperOctree.vtkClipHyperOctree_GetValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_InsideOutOff_14(HandleRef pThis);

		public virtual void InsideOutOff()
		{
			vtkClipHyperOctree.vtkClipHyperOctree_InsideOutOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_InsideOutOn_15(HandleRef pThis);

		public virtual void InsideOutOn()
		{
			vtkClipHyperOctree.vtkClipHyperOctree_InsideOutOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipHyperOctree_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClipHyperOctree.vtkClipHyperOctree_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkClipHyperOctree_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClipHyperOctree.vtkClipHyperOctree_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipHyperOctree_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClipHyperOctree NewInstance()
		{
			vtkClipHyperOctree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipHyperOctree.vtkClipHyperOctree_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipHyperOctree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkClipHyperOctree_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipHyperOctree SafeDownCast(vtkObjectBase o)
		{
			vtkClipHyperOctree vtkClipHyperOctree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipHyperOctree.vtkClipHyperOctree_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipHyperOctree = (vtkClipHyperOctree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipHyperOctree.Register(null);
				}
			}
			return vtkClipHyperOctree;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_SetClipFunction_21(HandleRef pThis, HandleRef arg0);

		public virtual void SetClipFunction(vtkImplicitFunction arg0)
		{
			vtkClipHyperOctree.vtkClipHyperOctree_SetClipFunction_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_SetGenerateClipScalars_22(HandleRef pThis, int _arg);

		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkClipHyperOctree.vtkClipHyperOctree_SetGenerateClipScalars_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_SetGenerateClippedOutput_23(HandleRef pThis, int _arg);

		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkClipHyperOctree.vtkClipHyperOctree_SetGenerateClippedOutput_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_SetInsideOut_24(HandleRef pThis, int _arg);

		public virtual void SetInsideOut(int _arg)
		{
			vtkClipHyperOctree.vtkClipHyperOctree_SetInsideOut_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_SetLocator_25(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkClipHyperOctree.vtkClipHyperOctree_SetLocator_25(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkClipHyperOctree_SetValue_26(HandleRef pThis, double _arg);

		public virtual void SetValue(double _arg)
		{
			vtkClipHyperOctree.vtkClipHyperOctree_SetValue_26(base.GetCppThis(), _arg);
		}
	}
}
