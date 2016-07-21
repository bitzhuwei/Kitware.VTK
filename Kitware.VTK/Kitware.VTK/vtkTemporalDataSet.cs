using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTemporalDataSet : vtkCompositeDataSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalDataSet";

		public new static readonly string MRClassNameKey;

		static vtkTemporalDataSet()
		{
			vtkTemporalDataSet.MRClassNameKey = "class vtkTemporalDataSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalDataSet"));
		}

		public vtkTemporalDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalDataSet New()
		{
			vtkTemporalDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalDataSet.vtkTemporalDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTemporalDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTemporalDataSet.vtkTemporalDataSet_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalDataSet_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalDataSet GetData(vtkInformation info)
		{
			vtkTemporalDataSet vtkTemporalDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalDataSet.vtkTemporalDataSet_GetData_01((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalDataSet = (vtkTemporalDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalDataSet.Register(null);
				}
			}
			return vtkTemporalDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalDataSet_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalDataSet GetData(vtkInformationVector v, int i)
		{
			vtkTemporalDataSet vtkTemporalDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalDataSet.vtkTemporalDataSet_GetData_02((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalDataSet = (vtkTemporalDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalDataSet.Register(null);
				}
			}
			return vtkTemporalDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTemporalDataSet_GetDataObjectType_03(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkTemporalDataSet.vtkTemporalDataSet_GetDataObjectType_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTemporalDataSet_GetExtentType_04(HandleRef pThis);

		public override int GetExtentType()
		{
			return vtkTemporalDataSet.vtkTemporalDataSet_GetExtentType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalDataSet_GetMetaData_05(HandleRef pThis, uint timestep, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformation GetMetaData(uint timestep)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalDataSet.vtkTemporalDataSet_GetMetaData_05(base.GetCppThis(), timestep, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalDataSet_GetMetaData_06(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkInformation GetMetaData(vtkCompositeDataIterator iter)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalDataSet.vtkTemporalDataSet_GetMetaData_06(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkTemporalDataSet_GetNumberOfTimeSteps_07(HandleRef pThis);

		public uint GetNumberOfTimeSteps()
		{
			return vtkTemporalDataSet.vtkTemporalDataSet_GetNumberOfTimeSteps_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalDataSet_GetTimeStep_08(HandleRef pThis, uint timestep, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetTimeStep(uint timestep)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalDataSet.vtkTemporalDataSet_GetTimeStep_08(base.GetCppThis(), timestep, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTemporalDataSet_HasMetaData_09(HandleRef pThis, uint timestep);

		public int HasMetaData(uint timestep)
		{
			return vtkTemporalDataSet.vtkTemporalDataSet_HasMetaData_09(base.GetCppThis(), timestep);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTemporalDataSet_HasMetaData_10(HandleRef pThis, HandleRef iter);

		public override int HasMetaData(vtkCompositeDataIterator iter)
		{
			return vtkTemporalDataSet.vtkTemporalDataSet_HasMetaData_10(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTemporalDataSet_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTemporalDataSet.vtkTemporalDataSet_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTemporalDataSet_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTemporalDataSet.vtkTemporalDataSet_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalDataSet_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTemporalDataSet NewInstance()
		{
			vtkTemporalDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalDataSet.vtkTemporalDataSet_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalDataSet_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalDataSet vtkTemporalDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalDataSet.vtkTemporalDataSet_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalDataSet = (vtkTemporalDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalDataSet.Register(null);
				}
			}
			return vtkTemporalDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTemporalDataSet_SetNumberOfTimeSteps_16(HandleRef pThis, uint numLevels);

		public void SetNumberOfTimeSteps(uint numLevels)
		{
			vtkTemporalDataSet.vtkTemporalDataSet_SetNumberOfTimeSteps_16(base.GetCppThis(), numLevels);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTemporalDataSet_SetTimeStep_17(HandleRef pThis, uint timestep, HandleRef dobj);

		public void SetTimeStep(uint timestep, vtkDataObject dobj)
		{
			vtkTemporalDataSet.vtkTemporalDataSet_SetTimeStep_17(base.GetCppThis(), timestep, (dobj == null) ? default(HandleRef) : dobj.GetCppThis());
		}
	}
}
